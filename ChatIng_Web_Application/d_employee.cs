using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data.SqlClient;

namespace ChatIng_Web_Application
{
    public partial class d_employee : Form
    {

        public d_employee()
        {
            InitializeComponent();
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

        private void d_employee_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            var query = "Select *from Employee";
            DataTable result = DataAccess.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Somethin Went Wrong");
                return;
            }
            data_view.AutoGenerateColumns = false;
            data_view.DataSource = result;
            data_view.Refresh();
            data_view.ClearSelection();
        }


        private void e_save_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }
        private void SaveData()
        {
            string id = e_Id.Text;
            string name = e_name.Text;
            string password = e_pass.Text;
            string address = e_Address.Text;
            DateTime dob = Convert.ToDateTime(e_date.Text);
            string phone = e_phone.Text;

            if (e_Id.Text == "")
            {
                var query = "insert into Employee([User Name],[Password],[Address],[DOB],[Phone Number]) output inserted.id values('" + name + "','" + password + "','" + address + "','" + dob + "','" + phone + "')";
                var result = DataAccess.GetData(query);
                if (result == null)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                e_Id.Text = result.Rows[0]["id"].ToString();
            }
            else
            {
                var query = "update Employee set [User Name]='" + name + "',[Password]='" + password + "',[Address]='" + address + "',[DOB]='" + dob + "',[Phone Number]='" + phone + "' Where id = " + id + "";
                var result = DataAccess.ExecuteData(query);
                if (result == false)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                MessageBox.Show("Success");
            }
            this.LoadData();
            for (int i = 0; i < data_view.Rows.Count; i++)
            {
                string selectedId = data_view.Rows[i].Cells[0].Value.ToString();
                if (selectedId == e_Id.Text)
                {
                    data_view.Rows[i].Selected = true;
                    break;
                }
            }

        }

        private void e_edit_Click(object sender, EventArgs e)
        {
        }
        private void data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
        }

        private void e_delete_Click(object sender, EventArgs e)
        {
            this.DeleteData();
        }
        private void DeleteData()
        {
            string id = e_Id.Text;
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

            var query = "delete from Employee where id = " + id + "";
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

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void e_new_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            e_Id.Text = "";
            e_name.Text = "";
            e_pass.Text = "";
            e_Address.Text = "";
            e_date.Text = "";
            e_phone.Text = "";
            data_view.ClearSelection();
        }

        private void data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = data_view.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.LoadSingleData(id);
        }
        private void LoadSingleData(string id)
        {
            var query = "select *from Employee where id =" + id + "";
            var result = DataAccess.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Something went Wrong");
                return;
            }
            e_Id.Text = result.Rows[0]["Id"].ToString();
            e_name.Text = result.Rows[0]["User Name"].ToString();
            e_pass.Text = result.Rows[0]["Password"].ToString();
            e_Address.Text = result.Rows[0]["Address"].ToString();
            e_date.Text = result.Rows[0]["DOB"].ToString();
            e_phone.Text = result.Rows[0]["Phone Number"].ToString();
        }

    }
}
