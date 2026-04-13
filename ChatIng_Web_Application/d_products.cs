using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
namespace ChatIng_Web_Application
{
    public partial class d_products : Form
    {
        public d_products()
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
       

        private void e_save_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }
        private void SaveData()
        {
            string id = p_Id.Text;
            string name = p_name.Text;
            string model = p_model.Text;
            string category = p_category.SelectedItem.ToString();
            string maxspeed = p_max_speed.Text;
            string year = p_year.Text;
            DateTime delivery = Convert.ToDateTime(p_date.Text);
            string price = p_Price.Text;

            if (p_Id.Text == "")
            {
                var query = "insert into Product([Name],[Model],[Category],[Year],[Max Speed],[Price],[Delivery Date]) output inserted.id values('" + name + "','" + model + "','" + category + "','" + year + "','" + maxspeed + "','" + price + "','" + delivery + "')";
                var result = DataAccess.GetData(query);
                if (result == null)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                p_Id.Text = result.Rows[0]["id"].ToString();
            }
            else
            {
                var query = "update Product set [Name]='" + name + "',[Model]='" + model + "',[Category]='" + category + "',[Year]='" + year + "',[Max Speed]='" + maxspeed + "',[Price]='" + price + "',[Delivery Date]='" + delivery + "' Where id = " + id + "";
                var result = DataAccess.ExecuteData(query);
                if (result == false)
                {
                    MessageBox.Show("Something Went Wrong");
                    return;
                }
                MessageBox.Show("Success");
            }
            this.LoadData();
            for (int i = 0; i < product_data.Rows.Count; i++)
            {
                string selectedId = product_data.Rows[i].Cells[0].Value.ToString();
                if (selectedId == p_Id.Text)
                {
                    product_data.Rows[i].Selected = true;
                    break;
                }
            }

        }

        private void p_delete_Click(object sender, EventArgs e)
        {
            this.DeleteData();
        }
        private void DeleteData()
        {
            string id = p_Id.Text;
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

            var query = "delete from Product where id = " + id + "";
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

        private void product_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void d_products_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void LoadData()
        {
            var query = "Select *from Product";
            DataTable result = DataAccess.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Somethin Went Wrong");
                return;
            }
            product_data.AutoGenerateColumns = false;
            product_data.DataSource = result;
            product_data.Refresh();
            product_data.ClearSelection();
        }

        private void p_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = product_data.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.LoadSingleData(id);
        }
        private void LoadSingleData(string id)
        {
            var query = "select *from Product where id =" + id + "";
            var result = DataAccess.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Something went Wrong");
                return;
            }
            p_Id.Text = result.Rows[0]["Id"].ToString();
            p_name.Text = result.Rows[0]["Name"].ToString();
            p_model.Text = result.Rows[0]["Model"].ToString();
            p_category.Text = result.Rows[0]["Category"].ToString();
            p_year.Text = result.Rows[0]["Year"].ToString();
            p_max_speed.Text = result.Rows[0]["Max Speed"].ToString();
            p_Price.Text = result.Rows[0]["Price"].ToString();
            p_date.Text = result.Rows[0]["Delivery Date"].ToString();
        }

        private void p_new_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            p_Id.Text = "";
            p_name.Text = "";
            p_model.Text = "";
            p_category.Text = "";
            p_year.Text = "";
            p_max_speed.Text = "";
            p_Price.Text = "";
            p_date.Text = "";
            product_data.ClearSelection();
        }
    }
}
