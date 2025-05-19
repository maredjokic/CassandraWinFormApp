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
    public partial class FormWorkerComments : Form
    {

        private string ID;
        private string FirstName;
        private string LastName;

        public FormWorkerComments(string id, string firstname,string lastname)
        {
            
            InitializeComponent();
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            ShowComments(id, firstname, lastname);
        }

        private void ShowComments(string id, string firstname, string lastname)
        {
            if (firstname == null) firstname = "";
            if (lastname == null) lastname = "";
            
           
            string comments = "";
            comments = "Worker: \n\t" + id +" "+ firstname + " " + lastname + "\n";
            comments = comments + "\nComments:\n\t";

            string[] readComments;

            readComments = DataProvider.GetWorkerComment(id);

            if (readComments != null)
            {
                foreach (string comment in readComments)
                {
                    if (comment == readComments[0])
                    {
                        comments = comments + comment;
                    }
                    else comments = comments + ",\n\t" + comment;
                }
            }
            rtbComments.Text = comments;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (tbxWriteComment.Text == null || tbxWriteComment.Text == "" || tbxWriteComment.Text.Length < 10)
            {
                MessageBox.Show("First write a comment in field! Comment should have 10 or more characters!");
            }
            else
            {
                string[] readComments = DataProvider.GetWorkerComment(ID);
                List<string> ls = new List<string>();
                if (readComments != null)
                {
                    foreach (string str in readComments)
                    {
                        ls.Add(str);
                    }
                }
                ls.Add(tbxWriteComment.Text);

                DataProvider.AddWorkerComments(ls, ID);

                MessageBox.Show("You added a comment successfully!");
                //this.Close();
                ShowComments(ID, FirstName, LastName);
            }
        }
    }
}
