using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Device
    {
        [System.ComponentModel.DisplayName("Device ID")]
        public string deviceID { get; set; }
        [System.ComponentModel.DisplayName("Name")]
        public string name { get; set; }
        [System.ComponentModel.DisplayName("Type")]
        public string type { get; set; }
        [System.ComponentModel.DisplayName("Material")]
        public string material { get; set; }
        [System.ComponentModel.DisplayName("Number")]
        public string number { get; set; }
        [System.ComponentModel.DisplayName("Size")]
        public string size { get; set; }
        [System.ComponentModel.DisplayName("Purpose")]
        public string purpose { get; set; }
        [System.ComponentModel.DisplayName("Accessories")]
        public string accessories { get; set; }
        [System.ComponentModel.DisplayName("PurchaseDate")]
        public string purchaseDate { get; set; }
        [System.ComponentModel.DisplayName("Office ID")]
        public string officeID { get; set; }
    }
}
