using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using pos_pc_parts;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Inventoryhehe
{
    public partial class Login : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection dbcon = new DBConnection();

        public Login()
        {
            InitializeComponent();
            MakeRoundedCorners(30);
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtUserPassword.Text))
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void MakeRoundedCorners(int radius)
        {
            var path = new GraphicsPath();
            int diameter = radius * 2;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);

            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);

            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);

            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            this.Region = new Region(path);
        }



        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            MakeRoundedCorners(10);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var path = new GraphicsPath();
            int radius = 20;
            int diameter = radius * 2;
            Rectangle rect = new Rectangle(0, 0, panel1.Width, panel1.Height);

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            panel1.Region = new Region(path);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            RoundPanel(panel1, 15);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            int radius = 2;
            var path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, button1.Width, button1.Height);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button1.Region = new Region(path);





            SetPlaceholder();

        }


        private void SetPlaceholder()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void RoundPanel(Panel panel, int radius)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InitializeComponent();


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtUserPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (cn = new MySqlConnection(dbcon.GetConnection()))
            {
                cn.Open();

                string query = "SELECT role FROM users WHERE username=@username AND password=@password";
                using (cm = new MySqlCommand(query, cn))
                {
                    cm.Parameters.AddWithValue("@username", username);
                    cm.Parameters.AddWithValue("@password", password);

                    object result = cm.ExecuteScalar(); 

                    if (result == null)
                    {
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string role = result.ToString(); 

                   
                    if (role == "admin")
                    {
                        this.Hide();
                        new frmAdmin().Show();
                    }
                    else if (role == "cashier")
                    {
                        this.Hide();
                        new frmCashier().Show();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role in database: " + role, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }
                
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Password_CheckedChanged(object sender, EventArgs e)
        {

            txtUserPassword.UseSystemPasswordChar = !Show_Password.Checked;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
