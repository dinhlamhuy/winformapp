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
using System.Security.Cryptography;

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

    

        private void txbPass_TextChanged(object sender, EventArgs e)
        {

        }
        static string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPass.Text;
            string md5Hash = CalculateMD5Hash(password);
            OleDbConnection connection = new OleDbConnection(Connect.ConnectionString);
            try
            {
                connection.Open();
                string query = $"SELECT COUNT(1) FROM [User] WHERE User_ID = '{username}' AND Password ='{md5Hash}'";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        //FormHome f = new FormHome();
                        FormScreen.FormMain f = new FormScreen.FormMain();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please check your credentials.");
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private void pictureEye_Click(object sender, EventArgs e)
        {

        }
        //show/hide password 
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
