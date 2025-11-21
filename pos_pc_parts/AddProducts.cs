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

                btnUpdate.Enabled = false;

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
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;

                txtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboCategories.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            cn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" || comboCategories.Text == "")
            {
                MessageBox.Show("Please complete the input needed!", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cn = new MySqlConnection(dbcon.GetConnection());

            cn.Open();


            string imagePath = string.IsNullOrEmpty(txtImagePath.Text) ? "no-image.jpg" : txtImagePath.Text;
            cm = new MySqlCommand("INSERT INTO products (product_name, image_path, category, price, quantity) VALUES (@name, @image_path ,@category, @price, @quantity)", cn);

            cm.Parameters.AddWithValue("@name", txtProductName.Text);
            cm.Parameters.AddWithValue("@category", comboCategories.Text);
            cm.Parameters.AddWithValue("@price", txtPrice.Text);
            cm.Parameters.AddWithValue("@quantity", txtQuantity.Text);
            cm.Parameters.AddWithValue("@image_path", imagePath);
            cm.ExecuteNonQuery();

            loadProducts();
            btnClear.PerformClick();
            MessageBox.Show("Product has been successfully added.", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);


            cn.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to update.", "Update Product",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();

            cm = new MySqlCommand("UPDATE products SET product_name = @name, category = @category, price = @price, quantity = @quantity WHERE product_id = @product_id", cn);
            cm.Parameters.AddWithValue("@name", txtProductName.Text);
            cm.Parameters.AddWithValue("@category", comboCategories.Text);
            cm.Parameters.AddWithValue("@price", txtPrice.Text);
            cm.Parameters.AddWithValue("@quantity", txtQuantity.Text);
            cm.Parameters.AddWithValue("@product_id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cm.ExecuteNonQuery();

            loadProducts();
            btnClear.PerformClick();
            MessageBox.Show("Product has been successfully updated.", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);


            cn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            comboCategories.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";


            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Copy selected file into Images folder
                string destFolder = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder); // create folder if not exist
                }

                string dest = Path.Combine(destFolder, Path.GetFileName(ofd.FileName));
                File.Copy(ofd.FileName, dest, true);

                // Load image into PictureBox
                pictureBox1.Image = Image.FromFile(dest);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                // Optional: store file name in a TextBox to save in database
                txtImagePath.Text = Path.GetFileName(dest);


            }
        }
    }
}
