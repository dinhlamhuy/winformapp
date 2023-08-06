using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformapp.Services;

namespace winformapp
{
    public partial class FormLogin : Form
    {
        private bool passwordVisible = false;

        public FormLogin()
        {
            InitializeComponent();
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void txbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPass.Text;

            OleDbConnection connection = new OleDbConnection(Connect.ConnectionString);
            try
            {
                connection.Open();
                string query = $"SELECT COUNT(1) FROM User WHERE User_ID = '{username}' AND Password ='{password}'";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please check your credentials.");
                    }
                }
                Console.WriteLine("Connected to the database.");

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            //FormHome f = new FormHome();
            //f.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEye_Click(object sender, EventArgs e)
        {

        }

        private void btnshowpass_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            if (passwordVisible)
            {
                txbPass.PasswordChar = '\0';
                txbPass.UseSystemPasswordChar = false; // Show the password as plain text
                btnshowpass.Image = Properties.Resources.eye_closed;

            }
            else
            {
                txbPass.PasswordChar = '*';
                txbPass.UseSystemPasswordChar = true;  // Hide the password
                btnshowpass.Image = Properties.Resources.eye_open;
            }
        }
    }
}
