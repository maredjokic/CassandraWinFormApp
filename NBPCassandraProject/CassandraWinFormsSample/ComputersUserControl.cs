using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;
using CassandraWinFormsSample.FormsExtra;

namespace CassandraWinFormsSample
{
    public partial class ComputersUserControl : UserControl
    {
        public ComputersUserControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(200, 180, 180, 180);
            dgvComputers.ReadOnly = true;
        }

        private void btnShowComputers_Click(object sender, EventArgs e)
        {
            ShowComputers();
        }
        private void ShowComputers()
        {
            List<Computer> computers = DataProvider.GetComputers();

            dgvComputers.DataSource = computers;
            dgvComputers.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteComputer_Click(object sender, EventArgs e)
        {
            if (tbxDeleteComputer.Text == null || tbxDeleteComputer.Text == "")
            {
                MessageBox.Show("First enter ID!");
            }
            else
            {
                if (DataProvider.GetComputer(tbxDeleteComputer.Text) == null)
                {
                    MessageBox.Show("Computer with this ID does not exist!");
                }
                else
                {
                    MessageBox.Show("Deleting is successful!");
                    DataProvider.DeleteComputer(tbxDeleteComputer.Text);
                    ShowComputers();
                }
            }
        }

        private void btnAddNewComputer_Click(object sender, EventArgs e)
        {
            if (tbxComputerID.Text == null || tbxComputerID.Text == "" || tbxBrand.Text == null || tbxBrand.Text == "")
            {
                MessageBox.Show("You should write ID and brand for computer!");
                return;
            }
            else if (DataProvider.GetComputer(tbxComputerID.Text) != null)
            {
                MessageBox.Show("This ID already exists! Try a different Id!");
                return;
            }

            Computer computer = new Computer();

            computer.computerId= (tbxComputerID.Text != null || tbxComputerID.Text != "") ? tbxComputerID.Text : null;
            computer.brand= (tbxBrand.Text != null || tbxBrand.Text != "") ? tbxBrand.Text : null;
            computer.code= (tbxCode.Text != null || tbxCode.Text != "") ? tbxCode.Text : null;
            computer.cpu= (tbxCPU.Text != null || tbxCPU.Text != "") ? tbxCPU.Text : null;
            computer.disc= (tbxDisc.Text != null || tbxDisc.Text != "") ? tbxDisc.Text : null;
            computer.graphics= (tbxGraphics.Text != null || tbxGraphics.Text != "") ? tbxGraphics.Text : null;
            computer.guaranty= (tbxGuaranty.Text != null || tbxGuaranty.Text != "") ? tbxGuaranty.Text : null;
            computer.laptopDesktop= (tbxLaptopDesktop.Text != null || tbxLaptopDesktop.Text != "") ? tbxLaptopDesktop.Text : null;
            computer.officeId= (tbxOfficeID.Text != null || tbxOfficeID.Text != "") ? tbxOfficeID.Text : null;
            computer.operatingSystem= (tbxOperatingSystem.Text != null || tbxOperatingSystem.Text != "") ? tbxOperatingSystem.Text : null;
            computer.purchasedDate= (tbxPurchasedDate.Text != null || tbxPurchasedDate.Text != "") ? tbxPurchasedDate.Text : null;
            computer.ram= (tbxRam.Text != null || tbxRam.Text != "") ? tbxRam.Text : null;
            computer.type= (tbxType.Text != null || tbxType.Text != "") ? tbxType.Text : null;

            if (DataProvider.AddComputer(computer))
            {
                MessageBox.Show("You added a new computer successfully!");
                ShowComputers();
                tbxComputerID.Text = "";
                tbxBrand.Text = "";
                tbxCode.Text = "";
                tbxCPU.Text = "";
                tbxDisc.Text = "";
                tbxGraphics.Text = "";
                tbxGuaranty.Text = "";
                tbxLaptopDesktop.Text = "";
                tbxOfficeID.Text = "";
                tbxOperatingSystem.Text = "";
                tbxPurchasedDate.Text = "";
                tbxRam.Text = "";
                tbxType.Text = "";
            }
            else
            {
                MessageBox.Show("Adding computer failed!");
            }
        }

        private void dgvComputers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = (string)dgvComputers.Rows[e.RowIndex].Cells[0].Value;

            string brand = (string)dgvComputers.Rows[e.RowIndex].Cells[3].Value;
            string type = (string)dgvComputers.Rows[e.RowIndex].Cells[1].Value;

            this.Hide();
            FormComputerRepairs fcr = new FormComputerRepairs(id, brand, type);
            fcr.ShowDialog();
            this.Show();
        }
    }
}
