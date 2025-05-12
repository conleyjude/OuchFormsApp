using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HiveMQtt.Client;
using HiveMQtt.Client.Options;
using HiveMQtt.MQTT5;
using HiveMQtt.Client.Events;
using HiveMQtt.MQTT5.Types;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System.ComponentModel;


namespace OuchFormsApp
{
    internal class MQTTPubSub : INotifyPropertyChanged
    {

        public HiveMQClient client;

        private string recentMessage = "";
        public string RecentMessage
        {
            get { return recentMessage; }
            set
            {
                recentMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RecentMessage"));
            }
        }

        private int recentPain = 0;
        public int RecentPain
        {
            get { return recentPain; }
            set
            {
                recentPain = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RecentPain"));
            }
        }

        private string recentMac = "";
        public string RecentMac
        {
            get { return recentMac; }
            set
            {
                recentMac = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RecentMac"));
            }
        }
        public List<Patient> patientList = [];
        private List<string> usedAddresses = [];

        public event PropertyChangedEventHandler? PropertyChanged;

        public MQTTPubSub()
        {
            client = new HiveMQClient(new HiveMQClientOptionsBuilder().
                                             WithBroker("b3c2e9f97aa1449ea629a6e7fc89071c.s1.eu.hivemq.cloud")
                                             .WithAutomaticReconnect(true)
                                             .WithUseTls(true)
                                             .WithPort(8883)
                                             .WithUserName("ouchTeam")
                                             .WithPassword("1OuchKSU$")
                                             .Build());
            client.OnMessageReceived += MessageHandler;
            client.AfterConnect += AfterConnectHandler;
            ConnectClient();
            RecentMessage = "";
        }

        void AfterConnectHandler(object? sender, AfterConnectEventArgs eventArgs)
        {
            SubscribeToTopic("ece591/#");
        }
        private void MessageHandler(object? sender, OnMessageReceivedEventArgs eventArgs)
        {
            RecentMessage = eventArgs.PublishMessage.PayloadAsString;
            string macAddress = eventArgs.PublishMessage.Topic.Substring(7, 12);
            RecentMac = macAddress;
            JsonObject obj = new JsonObject();
            if (macAddress != null && !usedAddresses.Contains(macAddress))
            {
                patientList.Add(new Patient("John", "Doe", macAddress));
                obj.Add("ID", "John Doe");
                string message = obj.ToJsonString();
                PublishToTopic("ece591/" + macAddress + "/Name", message);
                obj.Clear();
                usedAddresses.Add(macAddress);
            }
            else
            {
                string topic = eventArgs.PublishMessage.Topic.Substring(20);
                if (topic == "Pain")
                {
                    JsonNode ?node = JsonNode.Parse(RecentMessage);
                    int index = patientList.FindIndex(0, p => p.DeviceMAC == macAddress);
                    RecentPain = (int)node["Pain"];
                    patientList[index].PainReadings.Add(new KeyValuePair<DateTime, int>(DateTime.Now, RecentPain));
                }
            }
        }

        public async void ConnectClient()
        {
            try 
            {
                var done = await client.ConnectAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                MessageBox.Show("Wait for connection...");
                Task.Delay(1000);
                ConnectClient();
            }
            
        }

        public async void SubscribeToTopic(string topic)
        {
            try
            {
                var subDone = await client.SubscribeAsync(topic).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(0);
            }
        }

        public async void PublishToTopic(string topic, string message)
        {
            var pubDone = await client.PublishAsync(topic, message);
        }

        public List<string> GetPatientNames()
        {
            List<string> result = [];
            foreach (Patient p in patientList)
            {
                result.Add(p.FirstName + " " + p.LastName);
            }
            return result;
        }

        public List<int> GetPatientReadings(string firstName, string lastName)
        {
            if (firstName == null || lastName == null) return null;
            List<int> result = [];
            int index = patientList.FindIndex(0, p => p.FirstName == firstName && p.LastName == lastName);
            foreach(KeyValuePair<DateTime, int> pair in patientList[index].PainReadings)
            {
                result.Add(pair.Value);
            }
            return result;
        }

        public List<string> GetReadingTimes(string firstName, string lastName)
        {
            if (firstName == null || lastName == null) return null;
            List<string> result = [];
            int index = patientList.FindIndex(0, p => p.FirstName == firstName && p.LastName == lastName);
            foreach (KeyValuePair<DateTime, int> pair in patientList[index].PainReadings)
            {
                result.Add(pair.Key.ToString());
            }
            return result;
        }
    }
}
