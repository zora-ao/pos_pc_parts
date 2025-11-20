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
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new MySqlConnection(dbcon.GetConnection());

                cn.Open();

                cm = new MySqlCommand("INSERT INTO category(category_name)VALUES(@category_name)", cn);
                cm.Parameters.AddWithValue("@category_name", txtAddCat.Text);
                cm.ExecuteNonQuery();

                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
