using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OuchFormsApp
{
    internal class Patient
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string DeviceMAC{ get; private set; }
        public List<KeyValuePair<DateTime, int>> PainReadings { get; set; }

        public Patient(string first, string last, string mac)
        {
            FirstName = first;
            LastName = last;
            DeviceMAC = mac;
            PainReadings = [];
        }
    }
}
