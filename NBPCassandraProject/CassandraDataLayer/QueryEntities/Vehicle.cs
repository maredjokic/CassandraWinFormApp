using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Vehicle
    {
        [System.ComponentModel.DisplayName("Vehicle ID")]
        public string vehicleID { get; set; }
        [System.ComponentModel.DisplayName("Vehicle type")]
        public string vehicleType { get; set; }
        [System.ComponentModel.DisplayName("Brand")]
        public string brand { get; set; }
        [System.ComponentModel.DisplayName("Brand type")]
        public string brandType { get; set; }
        [System.ComponentModel.DisplayName("Engine power")]
        public string enginePower { get; set; }
        [System.ComponentModel.DisplayName("Number")]
        public string number { get; set; }
        [System.ComponentModel.DisplayName("Number of seats")]
        public string numberOfSeats { get; set; }
        [System.ComponentModel.DisplayName("Capacity")]
        public string capacity { get; set; }
        [System.ComponentModel.DisplayName("Year")]
        public string year { get; set; }

    }
}
