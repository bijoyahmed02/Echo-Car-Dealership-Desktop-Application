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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (guna2TabControl1.SelectedIndex)
            {
                case 0: // Assuming the first tab is Home
                    loadForm(new d_home());
                    break;
                case 1: // Assuming the second tab is Employee
                    loadForm(new d_employee());
                    break;
                case 2: // Assuming the third tab is Products
                    loadForm(new d_products());
                    break;
                case 3: // Assuming the fourth tab is Customar
                    loadForm(new d_Customar());
                    break;
                case 4: // Assuming the fifth tab is Billing
                    loadForm(new d_billing());
                    break;
                case 5: // Assuming the sixth tab is DProcess
                    loadForm(new d_dprocess());
                    break;
                case 6:
                    this.Hide(); // Hide the Admin_Page
                    Sign_In_Page signInPage = new Sign_In_Page(); // Create a new instance of Sign_In_Page
                    signInPage.Show(); // Show the Sign_In_Page
                    break;

                default:
                    break;
            }
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
    }
}
