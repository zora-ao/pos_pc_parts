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
    public partial class frmLogin : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection dbcon = new DBConnection();
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Content.Trim();
            string password = txtPassword.Content.Trim();
            string role = comboRole.SelectedItem.Trim();

            if (username == "" || password == "" || role == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (role == "Admin")
            {
                cn.ConnectionString = dbcon.GetConnection();
                cn.Open();
                cm = new MySqlCommand("SELECT * FROM users WHERE name=@username AND password=@password AND role='admin'", cn);
                cm.Parameters.AddWithValue("@username", username);
                cm.Parameters.AddWithValue("@password", password);
                MySqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    cn.Close();
                    this.Hide();
                    frmAdmin adminForm = new frmAdmin();
                    adminForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Admin credentials!");
                }
                cn.Close();
            }
            else if (role == "Cashier")
            {
                cn.ConnectionString = dbcon.GetConnection();
                cn.Open();
                cm = new MySqlCommand("SELECT * FROM users WHERE name=@username AND password=@password AND role='cashier'", cn);
                cm.Parameters.AddWithValue("@username", username);
                cm.Parameters.AddWithValue("@password", password);
                MySqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    int cashierId = Convert.ToInt32(dr["user_id"]);
                    string cashierName = dr["name"].ToString();

                    cn.Close();
                    this.Hide();

                  
                    frmCashier cashierForm = new frmCashier(cashierName, cashierId);
                    cashierForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Cashier credentials!");
                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("Please select a valid role!");
            }




        }

        private void Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_Password.Checked)
            {

                txtPassword.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
            }
        }

        private void cuiLabel2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCreateAcc createAccForm = new frmCreateAcc();
            this.Hide();
            createAccForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
