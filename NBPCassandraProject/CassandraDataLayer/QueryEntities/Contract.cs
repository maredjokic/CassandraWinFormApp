using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Contract
    {
        [System.ComponentModel.DisplayName("Contract ID")]
        public string contractID { get; set; }
        [System.ComponentModel.DisplayName("Name")]
        public string name { get; set; }
        [System.ComponentModel.DisplayName("Description")]
        public string description { get; set; }
        [System.ComponentModel.DisplayName("Value")]
        public string value { get; set; }
        [System.ComponentModel.DisplayName("Country")]
        public string country { get; set; }
        [System.ComponentModel.DisplayName("Company name")]
        public string companyName { get; set; }
        [System.ComponentModel.DisplayName("Subject")]
        public string subject { get; set; }
        [System.ComponentModel.DisplayName("Start time")]
        public string startTime { get; set; }
        [System.ComponentModel.DisplayName("End time")]
        public string endTime { get; set; }
        [System.ComponentModel.DisplayName("Type")]
        public string type { get; set; }
    }
}
