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
    public partial class d_Customar : Form
    {
        public d_Customar()
        {
            InitializeComponent();
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

        private void d_Customar_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void LoadData()
        {
            var query = "Select *from Customer";
            DataTable result = DataAccess.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Somethin Went Wrong");
                return;
            }
            customer_data.AutoGenerateColumns = false;
            customer_data.DataSource = result;
            customer_data.Refresh();
            customer_data.ClearSelection();
        }

        private void c_save_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }
        private void SaveData()
        {
            string id = c_Id.Text;
            string name = c_name.Text;
            string password = c_pass.Text;
            string address = c_Address.Text;
            string phone = c_phone.Text;
            string email = c_mail.Text;

            if (c_Id.Text == "")
            {
                var query = "insert into Customer([User Name],[Password],[Address],[Email],[Phone Number]) output inserted.id values('" + name + "','" + password + "','" + address + "','" + phone + "','" + email + "')";
                var result = DataAccess.GetData(query);
                if (result == null)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                c_Id.Text = result.Rows[0]["id"].ToString();
            }
            else
            {
                var query = "update Customer set [User Name]='" + name + "',[Password]='" + password + "',[Address]='" + address + "',[DOB]='" + phone + "',[Phone Number]='" + email + "' Where id = " + id + "";
                var result = DataAccess.ExecuteData(query);
                if (result == false)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                MessageBox.Show("Success");
            }
            this.LoadData();
            for (int i = 0; i < customer_data.Rows.Count; i++)
            {
                string selectedId = customer_data.Rows[i].Cells[0].Value.ToString();
                if (selectedId == c_Id.Text)
                {
                    customer_data.Rows[i].Selected = true;
                    break;
                }
            }

        }

        private void c_delete_Click(object sender, EventArgs e)
        {
            this.DeleteData();
        }
        private void DeleteData()
        {
            string id = c_Id.Text;
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

            var query = "delete from Customer where id = " + id + "";
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

        private void c_new_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            c_Id.Text = "";
            c_name.Text = "";
            c_pass.Text = "";
            c_Address.Text = "";
            c_mail.Text = "";
            c_phone.Text = "";
            customer_data.ClearSelection();
        }

        private void data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customer_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = customer_data.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.LoadSingleData(id);
        }
        private void LoadSingleData(string id)
        {
            var query = "select *from Customer where id =" + id + "";
            var result = DataAccess.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Something went Wrong");
                return;
            }
            c_Id.Text = result.Rows[0]["Id"].ToString();
            c_name.Text = result.Rows[0]["User Name"].ToString();
            c_pass.Text = result.Rows[0]["Password"].ToString();
            c_Address.Text = result.Rows[0]["Address"].ToString();
            c_mail.Text = result.Rows[0]["Email"].ToString();
            c_phone.Text = result.Rows[0]["Phone Number"].ToString();
        }

        private void c_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void c_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void c_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
