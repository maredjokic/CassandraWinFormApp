using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Office
    {
        [System.ComponentModel.DisplayName("Office ID")]
        public string officeID { get; set; }
        [System.ComponentModel.DisplayName("Name")]
        public string name { get; set; }
        [System.ComponentModel.DisplayName("Field of work")]
        public string fieldOfWork { get; set; }
        [System.ComponentModel.DisplayName("City")]
        public string city { get; set; }
        [System.ComponentModel.DisplayName("Country")]
        public string country { get; set; }
        [System.ComponentModel.DisplayName("Address")]
        public string streetAndNumber { get; set; }
        [System.ComponentModel.DisplayName("Number of rooms")]
        public string numberOfRooms { get; set; }
        [System.ComponentModel.DisplayName("Number of workers")]
        public string maxNumberOfWorkers { get; set; }
    }
}
