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
    public partial class categoryList : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection dbcon = new DBConnection();
        public categoryList()
        {
            InitializeComponent();
            loadCategory();
        }

        public void loadCategory()
        {
            dataGridView1.Rows.Clear();

            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();

            cm = new MySqlCommand("SELECT * FROM categories", cn);
            MySqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(
                    dr["id"].ToString(),
                    dr["name"].ToString()
                    );
            }
            dr.Close();
            cn.Close();
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddCat.Content == "")
                {
                    MessageBox.Show("Please enter category name.");
                    return;
                };

                cn = new MySqlConnection(dbcon.GetConnection());

                cn.Open();

                cm = new MySqlCommand("INSERT INTO categories(name) VALUES(@name)", cn);
                cm.Parameters.AddWithValue("@name", txtAddCat.Content);
                cm.ExecuteNonQuery();

                cn.Close();

                loadCategory();
                MessageBox.Show("Category has been successfully added.");
                txtAddCat.Content = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearCat_Click(object sender, EventArgs e)
        {
            txtAddCat.Content = "";
            btnSaveCat.Enabled = true;
            btnUpdateCat.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "colEdit")
            {
                btnSaveCat.Enabled = false;
                btnUpdateCat.Enabled = true;
                txtAddCat.Content = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (colName == "colDelete")
            {
                btnUpdateCat.Enabled = false;
                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn = new MySqlConnection(dbcon.GetConnection());
                    cn.Open();
                    cm = new MySqlCommand("DELETE FROM categories WHERE id=@id", cn);
                    cm.Parameters.AddWithValue("@id", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();
                    loadCategory();
                    MessageBox.Show("Category has been successfully deleted.");
                }
            }

        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            if (txtAddCat.Content == "")
            {
                MessageBox.Show("Please enter category name.");
                return;
            }
            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();

            cm = new MySqlCommand("UPDATE categories SET name=@name WHERE id=@id", cn);
            cm.Parameters.AddWithValue("@name", txtAddCat.Content);
            cm.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cm.ExecuteNonQuery();
            loadCategory();
            MessageBox.Show("Category has been successfully updated.");
            btnClearCat.PerformClick();
            btnSaveCat.Enabled = true;

            cn.Close();
        }
    }
}
