using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace ChatIng_Web_Application
{
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.mainpannel.Controls.Count > 0)
                this.mainpannel.Controls.RemoveAt(0);

            Form f = Form as Form;
            if (f == null)
            {
                MessageBox.Show("Failed to load the form.");
                return;
            }

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpannel.Controls.Add(f);
            this.mainpannel.Tag = f;
            f.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
           Sign_In_Page sign=new Sign_In_Page();
           sign.Show();
           this.Hide();
           
        }

        private void home_Click_1(object sender, EventArgs e)
        {
        }

        private void employee_Click(object sender, EventArgs e)
        {
        }

        private void product_Click(object sender, EventArgs e)
        {
        }

        private void customar_Click(object sender, EventArgs e)
        {
        }

        private void billing_Click(object sender, EventArgs e)
        {
        }

        private void dprocess_Click(object sender, EventArgs e)
        {
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
           // System.Diagnostics.Process.GetCurrentProcess().Kill();
            //Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            loadForm(new d_home());
        }

        private void guna2TabControl1_Click(object sender, EventArgs e)
        {

        }

        private void mainpannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
            //loadForm(new d_employee());
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            //loadForm(new d_products());
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
           

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            //loadForm(new d_billing());

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            //loadForm(new d_dprocess());

        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void employee_Click_1(object sender, EventArgs e)
        {
            //loadForm(new d_employee());


        }

        private void product_Click_1(object sender, EventArgs e)
        {
            //loadForm(new d_products());

        }

        private void customar_Click_1(object sender, EventArgs e)
        {
            //loadForm(new d_Customar());
        }

        private void billing_Click_1(object sender, EventArgs e)
        {
           // loadForm(new d_billing());
        }

        private void dprocess_Click_1(object sender, EventArgs e)
        {
            //loadForm(new d_dprocess());
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            var adminnpage = new Sign_In_Page();
            adminnpage.Show();
            this.Close();
        }
    }
}
