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
    public partial class FurnitureUserControl : UserControl
    {
        public FurnitureUserControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 180, 180, 180);
            dgvFurniture.ReadOnly = true;
        }

        private void btnShowFurniture_Click(object sender, EventArgs e)
        {
            ShowFurniture();
        }
        public void ShowFurniture()
        {
            List<Furniture> furnitures = DataProvider.GetFurnitures();

            dgvFurniture.DataSource = furnitures;
            dgvFurniture.Show();
        }

        private void btnDeleteFurniture_Click(object sender, EventArgs e)
        {
            if (tbxDeleteFurniture.Text == null || tbxDeleteFurniture.Text == "")
            {
                MessageBox.Show("First enter ID!");
            }
            else
            {
                if (DataProvider.GetFurniture(tbxDeleteFurniture.Text) == null)
                {
                    MessageBox.Show("Vehicle with this ID does not exist!");
                }
                else
                {
                    MessageBox.Show("Deleting is successful!");
                    DataProvider.DeleteFurniture(tbxDeleteFurniture.Text);
                    ShowFurniture();
                }
            }
        }

        private void btnAddNewFurniture_Click(object sender, EventArgs e)
        {
            if (tbxFurnitureID.Text == null || tbxFurnitureID.Text == "" || tbxType.Text == null || tbxType.Text == "")
            {
                MessageBox.Show("You should write ID and type for furniture!");
                return;
            }
            else if (DataProvider.GetFurniture(tbxFurnitureID.Text) != null)
            {
                MessageBox.Show("This ID already exists! Try a different Id!");
                return;
            }

            Furniture furniture = new Furniture();

            furniture.furnitureID = (tbxFurnitureID.Text != null || tbxFurnitureID.Text != "") ? tbxFurnitureID.Text : null;
            furniture.colour = (tbxColour.Text != null || tbxColour.Text != "") ? tbxColour.Text : null;
            furniture.material = (tbxMaterial.Text != null || tbxMaterial.Text != "") ? tbxMaterial.Text : null; 
            furniture.number = numNumber.Value.ToString();
            furniture.officeID = (tbxOfficeID.Text != null || tbxOfficeID.Text != "") ? tbxOfficeID.Text : null; 
            furniture.purchaseDate = (tbxPurchaseDate.Text != null || tbxPurchaseDate.Text != "") ? tbxPurchaseDate.Text : null;
            furniture.type = (tbxType.Text != null || tbxType.Text != "") ? tbxType.Text : null;


            if (DataProvider.AddFurniture(furniture))
            {
                MessageBox.Show("You added a new furniture successfully!");
                ShowFurniture();
                tbxFurnitureID.Text = "";
                tbxColour.Text = "";
                tbxMaterial.Text = "";
                numNumber.Value = 1;
                tbxOfficeID.Text = "";
                tbxPurchaseDate.Text = "";
                tbxType.Text = "";
            }
            else
            {
                MessageBox.Show("Adding furniture failed!");
            }
        }
    }
}
