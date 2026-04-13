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
    public partial class d_dprocess : Form
    {
        public d_dprocess()
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
        private void LoadData()
        {
            var query = "Select *from Admin";
            DataTable result = DataAccess.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Somethin Went Wrong");
                return;
            }
            Admin_Data.AutoGenerateColumns = false;
            Admin_Data.DataSource = result;
            Admin_Data.Refresh();
            Admin_Data.ClearSelection();
        }

        private void SaveData()
        {
            string id = c_Id.Text;
            string name = c_name.Text;
            string password = c_pass.Text;


            if (c_Id.Text == "")
            {
                var query = "insert into Admin([User Name],[Password]) output inserted.id values('" + name + "','" + password + "')";
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
                var query = "update Admin set [User Name]='" + name + "',[Password]='" + password + "' Where id = " + id + "";
                var result = DataAccess.ExecuteData(query);
                if (result == false)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                MessageBox.Show("Success");
            }
            this.LoadData();
            for (int i = 0; i < Admin_Data.Rows.Count; i++)
            {
                string selectedId = Admin_Data.Rows[i].Cells[0].Value.ToString();
                if (selectedId == c_Id.Text)
                {
                    Admin_Data.Rows[i].Selected = true;
                    break;
                }
            }

        }

        private void NewData()
        {
            c_Id.Text = "";
            c_name.Text = "";
            c_pass.Text = "";
            Admin_Data.ClearSelection();
        }



        private void c_save_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }



        private void c_new_Click(object sender, EventArgs e)
        {
            this.NewData();
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

            var query = "delete from Admin where id = " + id + "";
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

        private void c_delete_Click(object sender, EventArgs e)
        {
            this.DeleteData();
        }

        private void d_dprocess_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
