using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;

namespace CassandraWinFormsSample
{
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(0, 180, 180, 180);
            panel1.BackColor = Color.Transparent;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text.Length < 5 || tbxPassword.Text.Length < 5 || tbxPassword1.Text.Length < 5)
            {
                MessageBox.Show("Username and password should have five characters or more!");
            }
            else if (tbxPassword.Text.CompareTo(tbxPassword1.Text) != 0)
            {
                MessageBox.Show("Password is not entered correctly!");
            }
            else
            {
                Login login = DataProvider.GetUser(tbxUsername.Text);
                if (login != null)
                {
                    MessageBox.Show("Username already exists! Chose different username!");
                }
                else
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        login = new Login();
                        login.username = tbxUsername.Text;

                        login.password=GetMd5Hash(md5Hash, tbxPassword.Text);
                        DataProvider.AddUser(login);

                        tbxUsername.Text = "";
                        tbxPassword.Text = "";
                        tbxPassword1.Text = "";

                        MessageBox.Show("You added new admin successfully!");
                    }
                }
            }

                
               
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
