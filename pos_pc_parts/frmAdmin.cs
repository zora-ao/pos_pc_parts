using MySql.Data.MySqlClient;

namespace pos_pc_parts
{
    public partial class frmAdmin : Form
    {


        public frmAdmin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            LoadChildForm(new dashboardContents());

        }

        private void LoadChildForm(Form child)
        {
            admin_main_panel.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            admin_main_panel.Controls.Add(child);
            admin_main_panel.Tag = child;
            child.BringToFront();
            child.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoadChildForm(new dashboardContents());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AddProducts());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            LoadChildForm(new categoryList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadChildForm(new categoryList());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmSales());
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmAddUsers());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            this.Hide();
            loginForm.ShowDialog();

            
        }
    }
}
