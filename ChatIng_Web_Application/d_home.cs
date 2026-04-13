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
    public partial class d_home : Form
    {
        public d_home()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            d_home home = new d_home();
            home.Show();
            this.Hide();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            d_employee employee = new d_employee();
            employee.Show();
            this.Hide();
        }

        private void product_Click(object sender, EventArgs e)
        {
            d_products product = new d_products();
            product.Show();
            this.Hide();
        }

        private void customar_Click(object sender, EventArgs e)
        {
            d_Customar customar = new d_Customar();
            customar.Show();
            this.Hide();
        }

        private void billing_Click(object sender, EventArgs e)
        {
            d_billing billing = new d_billing();
            billing.Show();
            this.Hide();
        }

        private void dprocess_Click(object sender, EventArgs e)
        {
            d_dprocess dprocess = new d_dprocess();
            dprocess.Show();
            this.Hide();
        }

        private void employee_Click_1(object sender, EventArgs e)
        {

        }
    }
}
