using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassandraWinFormsSample
{
    public partial class CompanyRecordsForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0,0);

        public CompanyRecordsForm()
        {
            InitializeComponent();
            adminUserControl.Visible = false;
            officesUserControle.Visible = false;
            workersUserControl.Visible = false;
            computersUserControl1.Visible = false;
            vehiclesUserControl.Visible = false;
            contractUserControl.Visible = false;
            furnitureUserControl.Visible = false;
            devicesUserControl.Visible = false;

            panel1.BackColor = Color.FromArgb(200, 180, 180, 180);
            label1.BackColor = Color.FromArgb(0, 180, 180, 180);
            label2.BackColor = Color.FromArgb(0, 180, 180, 180);
           
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOffices_Click(object sender, EventArgs e)
        {
            adminUserControl.Visible = false;
            devicesUserControl.Visible = false;
            furnitureUserControl.Visible = false;
            contractUserControl.Visible = false;
            vehiclesUserControl.Visible = false;
            computersUserControl1.Visible = false;
            workersUserControl.Visible = false;
            officesUserControle.Visible = true;
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            adminUserControl.Visible = false;
            devicesUserControl.Visible = false;
            furnitureUserControl.Visible = false;
            contractUserControl.Visible = false;
            vehiclesUserControl.Visible = false;
            computersUserControl1.Visible = false;
            officesUserControle.Visible = false;
            workersUserControl.Visible = true;
        }

        private void btnComputers_Click(object sender, EventArgs e)
        {
            adminUserControl.Visible = false;
            devicesUserControl.Visible = false;
            furnitureUserControl.Visible = false;
            contractUserControl.Visible = false;
            vehiclesUserControl.Visible = false;
            workersUserControl.Visible = false;
            officesUserControle.Visible = false;
            computersUserControl1.Visible = true;
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            adminUserControl.Visible = false;
            devicesUserControl.Visible = false;
            furnitureUserControl.Visible = false;
            contractUserControl.Visible = false;
            workersUserControl.Visible = false;
            officesUserControle.Visible = false;
            computersUserControl1.Visible = false;
            vehiclesUserControl.Visible = true;
        }

        private void CompanyRecordsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            adminUserControl.Visible = false;
            devicesUserControl.Visible = false;
            furnitureUserControl.Visible = false;
            contractUserControl.Visible = false;
            workersUserControl.Visible = false;
            officesUserControle.Visible = false;
            computersUserControl1.Visible = false;
            vehiclesUserControl.Visible = false;
            contractUserControl.Visible = true;
        }

        private void btnFurniture_Click(object sender, EventArgs e)
        {
            adminUserControl.Visible = false;
            devicesUserControl.Visible = false;
            contractUserControl.Visible = false;
            workersUserControl.Visible = false;
            officesUserControle.Visible = false;
            computersUserControl1.Visible = false;
            vehiclesUserControl.Visible = false;
            contractUserControl.Visible = false;
            furnitureUserControl.Visible = true;
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            adminUserControl.Visible = false;
            contractUserControl.Visible = false;
            workersUserControl.Visible = false;
            officesUserControle.Visible = false;
            computersUserControl1.Visible = false;
            vehiclesUserControl.Visible = false;
            contractUserControl.Visible = false;
            furnitureUserControl.Visible = false;
            devicesUserControl.Visible = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void CompanyRecordsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void CompanyRecordsForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void CompanyRecordsForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            contractUserControl.Visible = false;
            workersUserControl.Visible = false;
            officesUserControle.Visible = false;
            computersUserControl1.Visible = false;
            vehiclesUserControl.Visible = false;
            contractUserControl.Visible = false;
            furnitureUserControl.Visible = false;
            devicesUserControl.Visible = false;
            adminUserControl.Visible = true;
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {

            CompanyRecordsForm crform = new CompanyRecordsForm();
            this.Hide();
            crform.ShowDialog();
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
