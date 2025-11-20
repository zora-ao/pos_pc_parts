using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pos_pc_parts
{
    public partial class AddProducts : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection dbcon = new DBConnection();
        public AddProducts()
        {
            InitializeComponent();
            loadProducts();
            comboCat();
        }

        public void loadProducts()
        {
            dataGridView1.Rows.Clear();
            cn = new MySqlConnection(dbcon.GetConnection());

            cn.Open();

            cm = new MySqlCommand("SELECT * FROM products", cn);

            MySqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(
                    dr["product_id"].ToString(),
                    dr["product_name"].ToString(),
                    dr["category"].ToString(),
                    dr["price"].ToString(),
                    dr["quantity"].ToString()
                    );
            }

            dr.Close();
            cn.Close();
        }

        public void comboCat()
        {
            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();
            MySqlCommand cm = new MySqlCommand("SELECT name FROM categories", cn);
            MySqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                comboCategories.Items.Add(dr["name"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "colDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this products?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn = new MySqlConnection(dbcon.GetConnection());
                    cn.Open();

                    cm = new MySqlCommand("DELETE FROM products WHERE product_id = @product_id", cn);

                    cm.Parameters.AddWithValue("@product_id", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                    cm.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    loadProducts();
                    MessageBox.Show("Product has been successfully deleted.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            if (colName == "colEdit")
            {

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection(dbcon.GetConnection());

            cn.Open();

            cm = new MySqlCommand("INSERT INTO products (product_name, category, price, quantity) VALUES (@name, @category, @price, @quantity)", cn);

            cm.Parameters.AddWithValue("@name", txtProductName.Text);
            cm.Parameters.AddWithValue("@category", comboCategories.Text);
            cm.Parameters.AddWithValue("@price", txtPrice.Text);
            cm.Parameters.AddWithValue("@quantity", txtQuantity.Text);
            cm.ExecuteNonQuery();

            loadProducts();
            MessageBox.Show("Product has been successfully added.", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);


            cn.Close();

        }
    }
}
