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


namespace CassandraWinFormsSample
{
    public partial class VehiclesUserControl : UserControl
    {
        public VehiclesUserControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 180, 180, 180);
            dgvVehicles.ReadOnly = true;
        }

        private void btnShowVehicle_Click(object sender, EventArgs e)
        {
            ShowVehicles();
        }

        private void ShowVehicles()
        {
            List<Vehicle> vehicles = DataProvider.GetVehicles();

            dgvVehicles.DataSource = vehicles;
            dgvVehicles.Show();
        }

        private void btnDeleteVehicles_Click(object sender, EventArgs e)
        {
            if (tbxDeleteVehicle.Text == null || tbxDeleteVehicle.Text == "")
            {
                MessageBox.Show("First enter ID!");
            }
            else
            {
                if (DataProvider.GetVehicle(tbxDeleteVehicle.Text) == null)
                {
                    MessageBox.Show("Vehicle with this ID does not exist!");
                }
                else
                {
                    MessageBox.Show("Deleting is successful!");
                    DataProvider.DeleteVehicle(tbxDeleteVehicle.Text);
                    ShowVehicles();
                }
            }
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            if (tbxVehicleID.Text == null || tbxVehicleID.Text == "")
            {
                MessageBox.Show("You should write ID for vehicle!");
                return;
            }
            else if (DataProvider.GetVehicle(tbxVehicleID.Text) != null)
            {
                MessageBox.Show("This ID already exists! Try a different ID!");
                return;
            }

            Vehicle vehicle = new Vehicle();

            vehicle.vehicleID = (tbxVehicleID.Text != null || tbxVehicleID.Text != "") ? tbxVehicleID.Text : null;
            vehicle.brand = (tbxBrand.Text != null || tbxBrand.Text != "") ? tbxBrand.Text : null;
            vehicle.brandType = (tbxBrandType.Text != null || tbxBrandType.Text != "") ? tbxBrandType.Text : null;
            vehicle.capacity = (tbxCapacity.Text != null || tbxCapacity.Text != "") ? tbxCapacity.Text : null;
            vehicle.enginePower = (tbxEnginePower.Text != null || tbxEnginePower.Text != "") ? tbxEnginePower.Text : null;
            vehicle.number = (tbxNumber.Text != null || tbxNumber.Text != "") ? tbxNumber.Text : null;
            vehicle.numberOfSeats = numNumberOfSeats.Value.ToString();
            vehicle.vehicleType = (tbxVehicleType.Text != null || tbxVehicleType.Text != "") ? tbxVehicleType.Text : null;
            vehicle.year = (tbxYear.Text != null || tbxYear.Text != "") ? tbxYear.Text : null;

            if (DataProvider.AddVehicle(vehicle))
            {
                MessageBox.Show("You added a new vehicle successfully!");
                ShowVehicles();
                tbxVehicleID.Text = "";
                tbxBrand.Text = "";
                tbxBrandType.Text = "";
                tbxCapacity.Text = "";
                tbxEnginePower.Text = "";
                tbxNumber.Text = "";
                numNumberOfSeats.Value = 1;
                tbxVehicleType.Text = "";
                tbxYear.Text = "";
            }
            else
            {
                MessageBox.Show("Adding vehicle failed!");
            }

        }
    }
}
