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
    public partial class DevicesUserControl : UserControl
    {
        public DevicesUserControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 180, 180, 180);
            dgvDevices.ReadOnly = true;
        }

        private void btnShowFurniture_Click(object sender, EventArgs e)
        {
            ShowDevices();
        }
        private void ShowDevices()
        {
            List<Device> devices = DataProvider.GetDevices();

            dgvDevices.DataSource = devices;
            dgvDevices.Show();
        }

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
            if (tbxDeleteDevice.Text == null || tbxDeleteDevice.Text == "")
            {
                MessageBox.Show("First enter ID!");
            }
            else
            {
                if (DataProvider.GetDevice(tbxDeleteDevice.Text) == null)
                {
                    MessageBox.Show("Device with this ID does not exist!");
                }
                else
                {
                    MessageBox.Show("Deleting is successful!");
                    DataProvider.DeleteDevice(tbxDeleteDevice.Text);
                    ShowDevices();
                }
            }
        }

        private void addNewDevice_Click(object sender, EventArgs e)
        {
            if (tbxDeviceID.Text == null || tbxDeviceID.Text == "" || tbxName.Text == null || tbxName.Text == "")
            {
                MessageBox.Show("You should write ID and name for device!");
                return;
            }
            else if (DataProvider.GetDevice(tbxDeviceID.Text) != null)
            {
                MessageBox.Show("This ID already exists! Try a different Id!");
                return;
            }
            Device device = new Device();

            device.deviceID = (tbxDeviceID.Text != null || tbxDeviceID.Text != "") ? tbxDeviceID.Text : null;
            device.accessories = (tbxAccessories.Text != null || tbxAccessories.Text != "") ? tbxAccessories.Text : null;
            device.material = (tbxMaterial.Text != null || tbxMaterial.Text != "") ? tbxMaterial.Text : null;
            device.name = (tbxName.Text != null || tbxName.Text != "") ? tbxName.Text : null;
            device.number = (tbxNumber.Text != null || tbxNumber.Text != "") ? tbxNumber.Text : null;
            device.officeID = (tbxOfficeID.Text != null || tbxOfficeID.Text != "") ? tbxOfficeID.Text : null;
            device.purchaseDate = (tbxPurchasedDate.Text != null || tbxPurchasedDate.Text != "") ? tbxPurchasedDate.Text : null;
            device.purpose = (tbxPurpose.Text != null || tbxPurpose.Text != "") ? tbxPurpose.Text : null;
            device.size = (tbxSize.Text != null || tbxSize.Text != "") ? tbxSize.Text : null;
            device.type = (tbxType.Text != null || tbxType.Text != "") ? tbxType.Text : null;


            if (DataProvider.AddDevice(device))
            {
                MessageBox.Show("You added a new device successfully!");
                ShowDevices();
                tbxDeviceID.Text = "";
                tbxAccessories.Text = "";
                tbxMaterial.Text = "";
                tbxName.Text = "";
                tbxNumber.Text = "";
                tbxPurchasedDate.Text = "";
                tbxPurpose.Text = "";
                tbxOfficeID.Text = "";
                tbxSize.Text = "";
                tbxType.Text = "";
            }
            else
            {
                MessageBox.Show("Adding computer failed!");
            }
        }
    }
}
