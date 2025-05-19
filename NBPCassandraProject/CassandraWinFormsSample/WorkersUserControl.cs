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
    public partial class WorkersUserControl : UserControl
    {
        public WorkersUserControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 180, 180, 180);
            dgvWorkers.ReadOnly = true;
        }

        private void btnShowOffice_Click(object sender, EventArgs e)
        {
            ShowWorkers();
        }

        private void ShowWorkers()
        {
            List<Worker> workers = DataProvider.GetWorkers();

            dgvWorkers.DataSource = workers;
            dgvWorkers.Show();
        }

        private void dgvWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {

            if (tbxDeleteWorker.Text == null || tbxDeleteWorker.Text == "")
            {
                MessageBox.Show("First enter ID!");
            }
            else
            {
                if (DataProvider.GetWorker(tbxDeleteWorker.Text) == null)
                {
                    MessageBox.Show("Worker with this ID does not exist!");
                }
                else
                {
                    MessageBox.Show("Deleting is successful!");
                    DataProvider.DeleteWorker(tbxDeleteWorker.Text);
                    ShowWorkers();
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewWorker_Click(object sender, EventArgs e)
        {
            if (tbxWorkerID.Text == null || tbxWorkerID.Text == ""||tbxLastName.Text == null || tbxLastName.Text == ""|| tbxFirstName.Text == null || tbxFirstName.Text == "")
            {
                MessageBox.Show("You should write ID, firstname and lastname for worker!");
                return;
            }
            else if (DataProvider.GetWorker(tbxWorkerID.Text) != null)
            {
                MessageBox.Show("This ID already exists! Try a different Id!");
                return;
            }
            Worker worker = new Worker();

            worker.workerID = (tbxWorkerID.Text != null || tbxWorkerID.Text != "") ? tbxWorkerID.Text : null; 
            worker.firstName= (tbxFirstName.Text != null || tbxFirstName.Text != "") ? tbxFirstName.Text : null;
            worker.lastName= (tbxLastName.Text != null || tbxLastName.Text != "") ? tbxLastName.Text : null;
            worker.email = (tbxEmail.Text != null || tbxEmail.Text != "") ? tbxEmail.Text : null;
            worker.addres = (tbxAddress.Text != null || tbxAddress.Text != "") ? tbxAddress.Text : null;
            worker.birthplace = (tbxBirthplace.Text != null || tbxBirthplace.Text != "") ? tbxBirthplace.Text : null;
            worker.birthyear = numBirthyear.Value.ToString();
            worker.faculty = (tbxFaculty.Text != null || tbxFaculty.Text != "") ? tbxFaculty.Text : null;
            worker.highSchool = (tbxHighschool.Text != null || tbxHighschool.Text != "") ? tbxHighschool.Text : null;
            worker.phone = (tbxPhone.Text != null || tbxPhone.Text != "") ? tbxPhone.Text : null;
            worker.officeID = (tbxOfficeID.Text != null || tbxOfficeID.Text != "") ? tbxOfficeID.Text : null;

            if (DataProvider.AddWorker(worker))
            {
                MessageBox.Show("You added a new worker successfully!");
                ShowWorkers();
                tbxFirstName.Text = "";
                tbxWorkerID.Text = "";
                tbxLastName.Text = "";
                tbxEmail.Text = "";
                tbxAddress.Text = "";
                tbxBirthplace.Text = "";
                numBirthyear.Value = 1996;
                tbxFaculty.Text = "";
                tbxHighschool.Text = "";
                tbxPhone.Text = "";
                tbxOfficeID.Text = "";
            }
            else
            {
                MessageBox.Show("Adding worker failed!");
            }

        }

        private void dgvWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvWorkers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string item = (string)dgvWorkers.Rows[e.RowIndex].Cells[0].Value;

            string name = (string)dgvWorkers.Rows[e.RowIndex].Cells[2].Value;
            string lastname = (string)dgvWorkers.Rows[e.RowIndex].Cells[3].Value;

            this.Hide();
            FormWorkerComments fwc = new FormWorkerComments(item, name, lastname);
            fwc.ShowDialog();
            this.Show();
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
