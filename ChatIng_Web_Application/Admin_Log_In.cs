using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChatIng_Web_Application
{
    public partial class Admin_Log_In : Form
    {
        public Admin_Log_In()
        {
            InitializeComponent();
        }
        private void signIn()
        {
            string name = userID_Box.Text.ToString();
            string pass = Password_Box.Text.ToString(); 

            var query = "SELECT * FROM Admin WHERE [User Name] = '" + name + "' AND [Password] = '" + pass + "'";

            var parameters = new SqlParameter[]
            {new SqlParameter("@username", name),
             new SqlParameter("@password", pass)};

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
            var adminPage = new Admin_Page();
            adminPage.Show();
            this.Hide();
        }


        private void Sign_IN_Click(object sender, EventArgs e)
        {
                this.signIn();

        }

        private void back_Click(object sender, EventArgs e)
        {
            var main = new Sign_In_Page();
            main.Show();
            this.Hide();
        }
    }
}
