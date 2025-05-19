using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;

namespace CassandraWinFormsSample
{
    public partial class FormLogIn : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public FormLogIn()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(200,180,180,180);
            Color clr= Color.FromArgb(0, 180, 180, 180);
            
            label1.BackColor = clr;
            label2.BackColor = clr;
            label3.BackColor = clr;
            label4.BackColor = clr;
            label5.BackColor = clr;
           

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 || textBox2.Text.Length < 5)
            {
                MessageBox.Show("Username and password should have five characters or more!");
                return;
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Write username and password! Try again!");
                return;
            }
            using (MD5 md5Hash = MD5.Create())
            {

                // string hash = GetMd5Hash(md5Hash, source);
                Login login = null;
                login= DataProvider.GetUser(textBox1.Text);

                if (login != null)
                {
                    if (VerifyMd5Hash(md5Hash, textBox2.Text, login.password))
                    {
                        textBox2.Text = "";
                        textBox1.Text = "";
                        CompanyRecordsForm crf = new CompanyRecordsForm();
                        this.Hide();
                        crf.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password or username! Try again!");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password or username! Try again!");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void FormLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void FormLogIn_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FormLogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 || textBox2.Text.Length < 5)
            {
                MessageBox.Show("Username and password should have five characters or more!");
                return;
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Write username and password! Try again!");
                return;
            }
            using (MD5 md5Hash = MD5.Create())
            {

                // string hash = GetMd5Hash(md5Hash, source);
                Login login = null;
                login = DataProvider.GetUser(textBox1.Text);

                if (login != null)
                {
                    if (VerifyMd5Hash(md5Hash, textBox2.Text, login.password))
                    {
                        textBox2.Text = "";
                        textBox1.Text = "";
                        CompanyRecordsForm crf = new CompanyRecordsForm();
                        this.Hide();
                        crf.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password or username! Try again!");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password or username! Try again!");
                }
            }
        }
    }
}
