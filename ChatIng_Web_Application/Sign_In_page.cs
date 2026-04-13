using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ChatIng_Web_Application
{
    public partial class Sign_In_Page : Form
    {
        public Sign_In_Page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Password_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Sign_IN_Click(object sender, EventArgs e)
        {

        }

        private void User_Login_Planel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void login()
        {
            string username = userID_Box.Text.Trim();
            string password = Password_Box.Text.Trim(); 

            string query = "SELECT COUNT(*) FROM UserInfo WHERE [User Name] = @username AND [Password] = @password;";

            var parameters = new SqlParameter[]
            {
        new SqlParameter("@username", username),
        new SqlParameter("@password", password) 
            };

            try
            {
                int count = DataAccess.ExecuteScalar(query, parameters);

                if (count > 0)
                {
                    MessageBox.Show("Login Successful");
                    OpenAdminPage(); 
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void OpenAdminPage()
        {
            var mainnn = new Main_Page();
            mainnn.Show();
            this.Hide();
        }
            private void Sign_IN_Click_1(object sender, EventArgs e)
            {
                this.login();
            }
            private void guna2ControlBox1_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }

        private void adminn_Click(object sender, EventArgs e)
        {
            var mainnn = new Admin_Log_In();
            mainnn.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var signup = new Sign_Up_Page();
            signup.Show();
            this.Close();
        }
    }
    }

