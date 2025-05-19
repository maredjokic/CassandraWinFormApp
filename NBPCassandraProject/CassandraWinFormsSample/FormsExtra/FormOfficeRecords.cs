using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;

namespace CassandraWinFormsSample.FormsExtra
{
    public partial class FormOfficeRecords : Form
    {
        private string ID;
        private string NName;
        private string Country;

        public FormOfficeRecords(string id, string officeName,string officeCountry)
        {
            InitializeComponent();
            ID = id;
            NName = officeName;
            Country = officeCountry;
            ShowRecords(id, NName, Country);
        }

        private void ShowRecords(string id, string officeName, string officeCountry)
        {
            if (officeName == null) officeName = "";
            if (officeCountry == null) officeCountry = "";


            string records = "";
            records = "Office: \n\t" + id + " " + officeName + " " + officeCountry + "\n";
            records = records + "\nRecords:\n\t";

            string[] readRecords;

            readRecords = DataProvider.GetOfficeRecords(id);

            if (readRecords != null)
            {
                foreach (string record in readRecords)
                {
                    if (record == readRecords[0])
                    {
                        records = records + record;
                    }
                    else records = records + ",\n\t" + record;
                }
            }
            rtbRecords.Text = records;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (tbxWriteRecord.Text == null || tbxWriteRecord.Text == "" || tbxWriteRecord.Text.Length < 10)
            {
                MessageBox.Show("First write a record in field! Record should have 10 or more characters!");
            }
            else
            {
                string[] readRecords = DataProvider.GetOfficeRecords(ID);
                List<string> ls = new List<string>();
                if (readRecords != null)
                {
                    foreach (string str in readRecords)
                    {
                        ls.Add(str);
                    }
                }
                ls.Add(tbxWriteRecord.Text);

                DataProvider.AddOfficeRecords(ls, ID);

                MessageBox.Show("You added a Record successfully!");
                //this.Close();
                ShowRecords(ID, NName, Country);
            }
        }
    }
}
