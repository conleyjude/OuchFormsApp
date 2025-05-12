using LiveChartsCore;
using LiveChartsCore.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.ComponentModel;
using System.Net;
using System.Text.Json.Nodes;


namespace OuchFormsApp
{
    public partial class DataHub : Form, INotifyPropertyChanged
    {
        private MQTTPubSub client = new MQTTPubSub();

        public event PropertyChangedEventHandler? PropertyChanged;

        private string lastMessage = "";
        private int lastPain = 0;

        public DataHub()
        {
            InitializeComponent();

            painChart1.TooltipTextSize = 30;

            painChart1.YAxes = new List<Axis>
            {
                new Axis
                {
                    MaxLimit = 11,
                    MinLimit = 0,
                    TextSize = 35,

                }
            };
            painChart1.XAxes = new List<Axis>
            {
                new Axis
                {
                    TextSize = 35,
                }
            };
            refreshTimer.Start();
            painReqTimer.Start();

        }

        public void UpdateUI()
        {
            painReqTimer.Stop();
            currentPainBox.Text = client.RecentPain.ToString();
            availableMessageText.Text = lastPain.ToString();
            painChangeText.Text = (client.RecentPain - lastPain).ToString();
            patientsBox.DataSource = client.GetPatientNames();
            string[] names = patientsBox.Text.Split(' ');
            if (names.Length > 1)
            {
                painChart1.Series = new ISeries[]
                {
                    new LineSeries<int>
                    {
                        Values = client.GetPatientReadings(names[0], names[1]),
                        Fill = null,
                        Stroke = new SolidColorPaint(SKColors.Purple) { StrokeThickness = 5 }
                    },
                };

                painChart1.XAxes = new List<Axis>
                {
                    new Axis
                    {
                        Labels = client.GetReadingTimes(names[0], names[1]),
                        TextSize = 35
                    },
                };

            }
            if (client.RecentPain > thresholdUpDown.Value) MessageBox.Show(patientsBox.Text + " has surpassed pain threshold of " +
                thresholdUpDown.Value.ToString());
            if (client.RecentPain - lastPain >= 4) MessageBox.Show("Pain spike detected for " + patientsBox.Text);
            lastPain = client.RecentPain;
            painReqTimer.Start();

        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            refreshTimer.Stop();
            if (client.RecentMessage != lastMessage)
            {
                UpdateUI();
                lastMessage = client.RecentMessage;
            }
            refreshTimer.Start();
        }

        private void painReqTimer_Tick(object sender, EventArgs e)
        {
            painReqTimer.Stop();
            JsonObject obj = new JsonObject();
            obj.Add("Push", true);
            client.PublishToTopic("ece591/" + client.RecentMac + "/Name", obj.ToJsonString());
            obj.Clear();
            painReqTimer.Start();
        }
    }
}