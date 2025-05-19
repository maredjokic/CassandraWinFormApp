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
    public partial class OfficesUserControle : UserControl
    {
        public OfficesUserControle()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 180, 180, 180);
            dgvOffices.ReadOnly = true;
        }

        private void btnShowOffice_Click(object sender, EventArgs e)
        {
            ShowOffices();
        }
        private void ShowOffices()
        {
            List<Office> offices = DataProvider.GetOffices();

            dgvOffices.DataSource = offices;
            dgvOffices.Show();
        }

        private void OfficesUserControle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvOffices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteOffice_Click(object sender, EventArgs e)
        {
            if (tbxDeleteOffice.Text == null || tbxDeleteOffice.Text == "")
            {
                MessageBox.Show("First enter ID!");
            }
            else
            {
                if (DataProvider.GetOffice(tbxDeleteOffice.Text) == null)
                {
                    MessageBox.Show("Office with this ID does not exist!");
                }
                else
                {
                    MessageBox.Show("Deleting is successful!");
                    DataProvider.DeleteOffice(tbxDeleteOffice.Text);
                    ShowOffices();
                }
            }
        }

        private void btnAddNewOffice_Click(object sender, EventArgs e)
        {
            if (tbxOfficeId.Text == null || tbxOfficeId.Text == "" || tbxName.Text == null || tbxName.Text == "" || tbxCity.Text == null || tbxCity.Text == "" || tbxCountry.Text == null || tbxCountry.Text == "")
            {
                MessageBox.Show("You should write ID, name, city and country for office!");
                return;
            }
            else if (DataProvider.GetOffice(tbxOfficeId.Text)!= null)
            {
                MessageBox.Show("This ID already exists! Try a different Id!");
                return;

            }
            Office office = new Office();

            office.officeID = (tbxOfficeId.Text!=null || tbxOfficeId.Text!="") ? tbxOfficeId.Text : null;
            office.city = (tbxCity.Text != null || tbxCity.Text != "") ? tbxCity.Text : null;
            office.country = (tbxCountry.Text != null || tbxCountry.Text != "") ? tbxCountry.Text : null;
            office.fieldOfWork = (tbxFieldOfWork.Text != null || tbxFieldOfWork.Text != "") ? tbxFieldOfWork.Text : null;
            office.streetAndNumber = (tbxStreetAndNumber.Text != null || tbxStreetAndNumber.Text != "") ? tbxStreetAndNumber.Text : null;
            office.name = (tbxName.Text != null || tbxName.Text != "") ? tbxName.Text : null;
            office.numberOfRooms = numNumberOfRooms.Value.ToString();
            office.maxNumberOfWorkers = numNumberOfWrokers.Value.ToString();

            if (DataProvider.AddOffice(office))
            {
                MessageBox.Show("You added a new office successfully!");
                ShowOffices();
                tbxOfficeId.Text = "";
                tbxCity.Text = "";
                tbxCountry.Text = "";
                tbxFieldOfWork.Text = "";
                tbxName.Text = "";
                tbxStreetAndNumber.Text = "";
                numNumberOfRooms.Value = 1;
                numNumberOfWrokers.Value = 1;
            }
            else{
                MessageBox.Show("Adding office failed!");
            }
        }

        private void dgvOffices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = (string)dgvOffices.Rows[e.RowIndex].Cells[0].Value;

            string officeName = (string)dgvOffices.Rows[e.RowIndex].Cells[1].Value;
            string officeCountry = (string)dgvOffices.Rows[e.RowIndex].Cells[4].Value;

            this.Hide();
            FormOfficeRecords rec = new FormOfficeRecords(id, officeName, officeCountry);
            rec.ShowDialog();
            this.Show();

        }
    }
}
