using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatIng_Web_Application
{
    public partial class Sign_Up_Page : Form
    {
        public Sign_Up_Page()
        {
            InitializeComponent();
            this.Load += new EventHandler(Sign_Up_Page_Load);
        }
        private void Emai_Click(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Page_Load(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
       

        private void SaveData()
        {
            string id = U_Id.Text;
            string name = f_name.Text;
            string lname = l_name.Text;
            string username = usernameTXT.Text;
            string mail = mail_text.Text;
            string phone = number_text.Text;
            string pass = password_text.Text;

            if (U_Id.Text == "")
            {
                var query = "insert into UserInfo([First Name],[Last name],[User Name],[Email],[Password],[Phone Number]) output inserted.id values('" + name + "','" + lname + "','" + username + "','" + mail + "','" + pass + "','"+phone+"')";
                var result = DataAccess.GetData(query);
                if (result == null)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                U_Id.Text = result.Rows[0]["id"].ToString();
            }
            else
            {
                var updateQuery = "UPDATE UserInfo SET [First Name]='" + name + "', [Last Name]='" + lname + "', [User Name]='" + username + "', [Email]='" + mail + "' WHERE id = " + id;
                var result = DataAccess.ExecuteData(updateQuery);
                if (result == false)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                    MessageBox.Show("Success");
                    OpenForm();
            }
        }
        private void OpenForm()
        {
            
            var maill = new Mail_Verification();
            maill.Show();
            this.Hide();

        }
        private void sign_in_Click(object sender, EventArgs e)
        {
            if (password_text.Text != re_password_text.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            if (password_text.Text.Length <= 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            this.SaveData();
        }

        private void log_in_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Sign_In_Page().Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
