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

    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }
        int mov;
        int movx;
        int movy;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Max_Price_Bar_ValueChanged(object sender, EventArgs e)
        {
            max_Price_max.Text=Max_Price_Bar.Value.ToString()+"$";
        }

        private void max_year_lable_Validating(object sender, CancelEventArgs e)
        {

        }

        private void max_km_range_Validating(object sender, CancelEventArgs e)
        {

        }

        private void max_km_range_Click(object sender, EventArgs e)
        {

        }

        private void year_bar_ValueChanged(object sender, EventArgs e)
        {
            max_year_lable.Text = year_bar.Value.ToString()+"yr";
        }

        private void km_bar_ValueChanged(object sender, EventArgs e)
        {
            max_km_range.Text=km_bar.Value.ToString()+"km";
        }

        private void car1_Click(object sender, EventArgs e)
        {
            Full_image_car.Image=car1.Image;
            Max_Price_Lable.Text=Price1.Text;
            
        }

        private void car2_Click(object sender, EventArgs e)
        {
            Full_image_car.Image = car2.Image;
            Max_Price_Lable.Text = Price2.Text;


        }

        private void car3_Click(object sender, EventArgs e)
        {
            Full_image_car.Image = car3.Image;
            Max_Price_Lable.Text = Price3.Text;


        }

        private void car4_Click(object sender, EventArgs e)
        {
            Full_image_car.Image = car4.Image;
            Max_Price_Lable.Text = Price4.Text;


        }

        private void car5_Click(object sender, EventArgs e)
        {
            Full_image_car.Image = car5.Image;
            Max_Price_Lable.Text = Price5.Text;


        }

        private void car6_Click(object sender, EventArgs e)
        {
            Full_image_car.Image = car6.Image;
            Max_Price_Lable.Text = Price6.Text;


        }

        private void car7_Click(object sender, EventArgs e)
        {
            Full_image_car.Image = car7.Image;
            Max_Price_Lable.Text = Price7.Text;


        }

        private void Price7_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 1)
            {
                this.Location = Screen.AllScreens[1].WorkingArea.Location;
            }
            else
            {
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }

        }
        /*
        private void Main_Page_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 1)
            {
                this.Location = Screen.AllScreens[1].WorkingArea.Location;
            }
            else
            {
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
        }

        private void Main_Page_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void Main_Page_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void Main_Page_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        */

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            var main = new payment();
            main.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var main = new Main_Page();
            main.Show();
            this.Close();
        }

        private void Shop_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;

        }

        private void Shop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }

        }

        private void Shop_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;

        }
    }
}
