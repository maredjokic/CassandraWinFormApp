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
    public partial class ContractUserControl : UserControl
    {
        public ContractUserControl()
        {
            InitializeComponent();
            this.BackColor= Color.FromArgb(200, 180, 180, 180);
            dgvContracts.ReadOnly = true;
        }

        private void btnShowContracts_Click(object sender, EventArgs e)
        {
            ShowContracts();
        }
        private void ShowContracts()
        {
            List<Contract> contracts = DataProvider.GetContracts();

            dgvContracts.DataSource = contracts;
            dgvContracts.Show();
        }

        private void dgvContracts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            if (tbxDeleteContract.Text == null || tbxDeleteContract.Text == "")
            {
                MessageBox.Show("First enter ID!");
            }
            else
            {
                if (DataProvider.GetContract(tbxDeleteContract.Text) == null)
                {
                    MessageBox.Show("Contract with this ID does not exist!");
                }
                else
                {
                    MessageBox.Show("Deleting is successful!");
                    DataProvider.DeleteContract(tbxDeleteContract.Text);
                    ShowContracts();
                }
            }
        }

        private void btnAddNewContract_Click(object sender, EventArgs e)
        {
            if (tbxContractID.Text == null || tbxContractID.Text == "")
            {
                MessageBox.Show("You should write ID for contract!");
                return;
            }
            else if (DataProvider.GetContract(tbxContractID.Text) != null)
            {
                MessageBox.Show("This ID already exists! Try a different Id!");
                return;
            }

            Contract contract = new Contract();


            contract.contractID = (tbxContractID.Text != null || tbxContractID.Text != "") ? tbxContractID.Text : null;
            contract.companyName = (tbxCompanyName.Text != null || tbxCompanyName.Text != "") ? tbxCompanyName.Text : null;
            contract.country= (tbxCountry.Text != null || tbxCountry.Text != "") ? tbxCountry.Text : null;
            contract.description= (tbxDescription.Text != null || tbxDescription.Text != "") ? tbxDescription.Text : null;
            contract.endTime= (tbxEndTime.Text != null || tbxEndTime.Text != "") ? tbxEndTime.Text : null;
            contract.name= (tbxName.Text != null || tbxName.Text != "") ? tbxName.Text : null;
            contract.startTime= (tbxStartTime.Text != null || tbxStartTime.Text != "") ? tbxStartTime.Text : null;
            contract.subject= (tbxSubject.Text != null || tbxSubject.Text != "") ? tbxSubject.Text : null;
            contract.type= (tbxType.Text != null || tbxType.Text != "") ? tbxType.Text : null;
            contract.value= (tbxValue.Text != null || tbxValue.Text != "") ? tbxValue.Text : null;



            if (DataProvider.AddContract(contract))
            {
                MessageBox.Show("You added a new contract successfully!");
                ShowContracts();
                tbxContractID.Text = "";
                tbxCompanyName.Text = "";
                tbxCountry.Text = "";
                tbxDescription.Text = "";
                tbxEndTime.Text = "";
                tbxName.Text = "";
                tbxStartTime.Text = "";
                tbxSubject.Text = "";
                tbxType.Text = "";
                tbxValue.Text = "";
            }
            else
            {
                MessageBox.Show("Adding contract failed!");
            }
        }
    }
}
