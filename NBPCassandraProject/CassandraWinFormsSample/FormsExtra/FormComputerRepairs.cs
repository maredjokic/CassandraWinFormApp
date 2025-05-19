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
    public partial class FormComputerRepairs : Form
    {

        private string ID;
        private string Brand;
        private string Type;


        public FormComputerRepairs(string id, string brand,string type)
        {
            InitializeComponent();
            ID= id;
            Brand= brand;
            Type= type;
            ShowRepairs( id, brand, type);
        }

        private void ShowRepairs(string id, string brand, string type)
        {
            if (brand == null) brand = "";
            if (type == null) type = "";


            string repairs = "";
            repairs = "Computer: \n\t" + id + " " + brand + " " + type + "\n";
            repairs = repairs + "\nRepairs and upgrades:\n\t";

            string[] readRepairs;

            readRepairs = DataProvider.GetComputerRepairs(id);

            if (readRepairs != null)
            {
                foreach (string repair in readRepairs)
                {
                    if (repair == readRepairs[0])
                    {
                        repairs = repairs + repair;
                    }
                    else repairs = repairs + ",\n\t" + repair;
                }
            }
            rtbRepairs.Text = repairs;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddrepair_Click(object sender, EventArgs e)
        {
            if (tbxWriteRepair.Text == null || tbxWriteRepair.Text == "" || tbxWriteRepair.Text.Length < 10)
            {
                MessageBox.Show("First write a repair or upgrade in field! Text about repair or upgrade should have 10 or more characters!");
            }
            else
            {
                string[] readRepairs = DataProvider.GetComputerRepairs(ID);
                List<string> ls = new List<string>();
                if (readRepairs != null)
                {
                    foreach (string str in readRepairs)
                    {
                        ls.Add(str);
                    }
                }
                ls.Add(tbxWriteRepair.Text);

                DataProvider.AddComputerRepairs(ls, ID);

                MessageBox.Show("You added a repair or update successfully!");
                //this.Close();
                ShowRepairs(ID, Brand, Type);
            }
        }
    }
}
