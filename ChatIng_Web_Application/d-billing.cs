using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
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
    public partial class d_billing : Form
    {
        public d_billing()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            

        }

        private void home_Click(object sender, EventArgs e)
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
       
        private void p_save_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }
        private void SaveData()
        {
            string b_id = b_cid.Text;
            string name = b_cname.Text;
            string cnumber = b_cnumber.Text;
            string pin= b_pin.Text;
            string amount = b_amount.Text;
            string p_id = id_product.Text;
            DateTime edate = Convert.ToDateTime(b_edate.Text);
            if (b_cid.Text == "")
            {
                var query = "insert into Payment([Card Name],[Card Number],[Expire Date],[CVV],[Amount],[ProductID]) output inserted.id values('" + name + "','" + cnumber + "','" + edate + "','" + pin + "','" + amount + "','"+p_id+"')";
                var result = DataAccess.GetData(query);
                if (result == null)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                b_cid.Text = result.Rows[0]["id"].ToString();
            }
            else
            {
                var query = "update Payment set [Card Name]='" + name + "',[Card Number]='" + cnumber + "',[Expire Date]='" + edate + "',[CVV]='" + pin + "',[Amount]='" + amount + "',[ProductID]='"+p_id+"' Where id = " + b_id + "";
                var result = DataAccess.ExecuteData(query);
                if (result == false)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                MessageBox.Show("Success");
            }
            this.LoadData();
            for (int i = 0; i < bill_data.Rows.Count; i++)
            {
                string selectedId = bill_data.Rows[i].Cells[0].Value.ToString();
                if (selectedId == b_cid.Text)
                {
                    bill_data.Rows[i].Selected = true;
                    break;
                }
            }

        }


        private void p_edit_Click(object sender, EventArgs e)
        {
        }
        private void p_delete_Click(object sender, EventArgs e)
        {

        }
        private void d_billing_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            var query = "Select *from Payment";
            DataTable result = DataAccess.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Somethin Went Wrong");
                return;
            }
            bill_data.AutoGenerateColumns = false;
            bill_data.DataSource = result;
            bill_data.Refresh();
            bill_data.ClearSelection();
        }
        private void Customar_Bill_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            b_cid.Text = "";
            b_cname.Text = "";
            b_cnumber.Text = "";
            b_edate.Text = "";
            b_amount.Text = "";
            b_pin.Text = "";
            bill_data.ClearSelection();
        }
        private void bill_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = bill_data.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.LoadSingleData(id);
        }
        private void LoadSingleData(string id)
        {
            var query = "select *from Payment where id =" + id + "";
            var result = DataAccess.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Something went Wrong");
                return;
            }
            b_cid.Text = result.Rows[0]["Id"].ToString();
            b_cname.Text = result.Rows[0]["Card Name"].ToString();
            b_cnumber.Text = result.Rows[0]["Card Number"].ToString();
            b_edate.Text = result.Rows[0]["Expire Date"].ToString();
            b_pin.Text = result.Rows[0]["CVV"].ToString();
            b_amount.Text = result.Rows[0]["Amount"].ToString();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            this.DeleteData();
        }
        private void DeleteData()
        {
            string id = b_cid.Text;
            if (id == "")
            {
                MessageBox.Show("Please selected a row first");
                return;
            }
            var userResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (userResult == DialogResult.No)
            {
                return;
            }

            var query = "delete from Payment where id = " + id + "";
            var result = DataAccess.ExecuteData(query);
            if (result == false)
            {
                MessageBox.Show("SomeThing Went Wrong");
                return;
            }
            MessageBox.Show("Deleted");
            this.LoadData();
            this.NewData();
        }
    }
}
