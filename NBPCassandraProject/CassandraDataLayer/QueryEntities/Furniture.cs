using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Furniture
    {
        [System.ComponentModel.DisplayName("Furniture ID")]
        public string furnitureID { get; set; }
        [System.ComponentModel.DisplayName("Type")]
        public string type { get; set; }
        [System.ComponentModel.DisplayName("Material")]
        public string material { get; set; }
        [System.ComponentModel.DisplayName("Colour")]
        public string colour { get; set; }
        [System.ComponentModel.DisplayName("Number")]
        public string number { get; set; }
        [System.ComponentModel.DisplayName("Purchase date")]
        public string purchaseDate { get; set; }
        [System.ComponentModel.DisplayName("Office ID")]
        public string officeID { get; set; }
    }
}
