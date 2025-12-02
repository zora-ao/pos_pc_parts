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
    public partial class frmCreateAcc : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection dbcon = new DBConnection();
        public frmCreateAcc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_Password.Checked)
            {
                txtPassword.PasswordChar = false;
                txtRePass.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
                txtRePass.PasswordChar = true;
            }
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Content.Trim();
            string pass = txtPassword.Content.Trim();
            string repass = txtRePass.Content.Trim();
            if (username == "" || pass == "" || repass == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (pass != repass)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();
            cm = new MySqlCommand("INSERT INTO users (name, password, role) VALUES (@username, @password, 'cashier')", cn);
            cm.Parameters.AddWithValue("@username", username);
            cm.Parameters.AddWithValue("@password", pass);
            cm.ExecuteNonQuery();
            cn.Close();


            MessageBox.Show("Account created successfully! Please login.");

            txtUsername.Content = "";
            txtPassword.Content = "";
            txtRePass.Content = "";

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
