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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        

        private void SaveData()
        {
            string b_id = y_ID.Text;
            string name = b_cname.Text;
            string cnumber = Card_number.Text;
            string pin = p_pin.Text;
            string amount = p_amount.Text;
            string p_id = Product_ID.Text;
            DateTime edate = Convert.ToDateTime(e_date.Text);
           
            if (y_ID.Text == "")
            {
                var query = "insert into Payment([Card Name],[Card Number],[Expire Date],[CVV],[Amount],[ProductID])  values('" + name + "','" + cnumber + "','" + edate + "','" + pin + "','" + amount + "','" + p_id + "')";
                var result = DataAccess.GetData(query);
                if (result == null)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                y_ID.Text = result.Rows[0]["id"].ToString();
            }
            else
            {
                var query = "update Payment set [Card Name]='" + name + "',[Card Number]='" + cnumber + "',[Expire Date]='" + edate + "',[CVV]='" + pin + "',[Amount]='" + amount + "',[ProductID]='" + p_id + "' Where id = " + b_id + "";
                var result = DataAccess.ExecuteData(query);
                if (result == false)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                MessageBox.Show("Success");
            }
            

        }

        private void payment_Conform_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }

        private void Bkt_Click(object sender, EventArgs e)
        {
            var  shopp =new Shop();
            shopp.Show();
            this.Close();
        }
    }
}
