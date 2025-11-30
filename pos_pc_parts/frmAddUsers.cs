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
    public partial class frmAddUsers : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection dbcon = new DBConnection();
        public frmAddUsers()
        {
            InitializeComponent();
            loadUsers();
        }

        public void loadUsers()
        {
            dataGridView1.Rows.Clear();

            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();

            string query = "SELECT * FROM users";
            cm = new MySqlCommand(query, cn);
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(
                    dr["name"].ToString(),
                    dr["role"].ToString()
                    );
            }
            dr.Close();
            cn.Close();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();

            if (txtUserName.Content == "" || txtUserPassword.Content == "" || comboUserRole.SelectedItem == null)
            {
                MessageBox.Show("Please complete all fields.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cm = new MySqlCommand("SELECT COUNT(*) FROM users WHERE name = @name", cn);
            cm.Parameters.AddWithValue("@name", txtUserName.Content);

            int userCount = Convert.ToInt32(cm.ExecuteScalar());

            if (userCount > 0)
            {
                MessageBox.Show("This username is already taken.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cn.Close();
                return;
            }

            cm = new MySqlCommand("INSERT INTO users(name, password, role) VALUES(@name, @password, @role)", cn);


            cm.Parameters.AddWithValue("@name", txtUserName.Content);
            cm.Parameters.AddWithValue("@password", txtUserPassword.Content);
            cm.Parameters.AddWithValue("@role", comboUserRole.SelectedItem.ToString());
            cm.ExecuteNonQuery();
            cn.Close();
            loadUsers();

            MessageBox.Show("User has been successfully added.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colRemoveUser")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn = new MySqlConnection(dbcon.GetConnection());
                    cn.Open();
                    cm = new MySqlCommand("DELETE FROM users WHERE name=@name", cn);
                    cm.Parameters.AddWithValue("@name", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();
                    loadUsers();
                    MessageBox.Show("User has been successfully deleted.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
