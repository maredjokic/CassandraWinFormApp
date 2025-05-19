using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Computer 
    {
        [System.ComponentModel.DisplayName("Computer ID")]
        public string computerId { get; set; }
        [System.ComponentModel.DisplayName("Code")]
        public string code { get; set; }
        [System.ComponentModel.DisplayName("Laptop/Desktop")]
        public string laptopDesktop { get; set; }
        [System.ComponentModel.DisplayName("Brand")]
        public string brand { get; set; }
        [System.ComponentModel.DisplayName("Type")]
        public string type { get; set; }
        [System.ComponentModel.DisplayName("CPU")]
        public string cpu { get; set; }
        [System.ComponentModel.DisplayName("Disc")]
        public string disc { get; set; }
        [System.ComponentModel.DisplayName("Ram")]
        public string ram { get; set; }
        [System.ComponentModel.DisplayName("Grafics")]
        public string graphics { get; set; }
        [System.ComponentModel.DisplayName("Operating system")]
        public string operatingSystem { get; set; }
        [System.ComponentModel.DisplayName("Guaranty")]
        public string guaranty { get; set; }
        [System.ComponentModel.DisplayName("Office ID")]
        public string officeId { get; set; }
        [System.ComponentModel.DisplayName("Purchased date")]
        public string purchasedDate { get; set; }//datum kupovine

        public List<string> comments { get; set; }
    }
}
