using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Worker
    {
        [System.ComponentModel.DisplayName("Worker ID/JMBG")]
        public string workerID { get; set; }
        [System.ComponentModel.DisplayName("Office ID")]
        public string officeID { get; set; }
        [System.ComponentModel.DisplayName("Firstname")]
        public string firstName { get; set; }
        [System.ComponentModel.DisplayName("Lastname")]
        public string lastName { get; set; }
        [System.ComponentModel.DisplayName("Phone")]
        public string phone { get; set; }
        [System.ComponentModel.DisplayName("Email")]
        public string email { get; set; }
        [System.ComponentModel.DisplayName("Address")]
        public string addres { get; set; }
        [System.ComponentModel.DisplayName("Birth year")]
        public string birthyear { get; set; }
        [System.ComponentModel.DisplayName("Birth place")]
        public string birthplace { get; set; }
        [System.ComponentModel.DisplayName("High school")]
        public string highSchool { get; set; }
        [System.ComponentModel.DisplayName("Faculty")]
        public string faculty { get; set; }

    }
}
