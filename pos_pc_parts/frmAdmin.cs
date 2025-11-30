using MySql.Data.MySqlClient;

namespace pos_pc_parts
{
    public partial class frmAdmin : Form
    {


        public frmAdmin()
        {
          
            defaultLoad();


        }

        public void defaultLoad()
        {
            admin_main_panel.Controls.Clear();

            dashboardContents dashboard = new dashboardContents();
            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;
            admin_main_panel.Controls.Add(dashboard);
            admin_main_panel.Tag = dashboard;
            dashboard.BringToFront();
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            defaultLoad();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_main_panel.Controls.Clear();

            AddProducts addProd = new AddProducts();
            addProd.TopLevel = false;
            addProd.FormBorderStyle = FormBorderStyle.None;
            addProd.Dock = DockStyle.Fill;
            admin_main_panel.Controls.Add(addProd);
            admin_main_panel.Tag = addProd;
            addProd.BringToFront();
            addProd.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            admin_main_panel.Controls.Clear();

            categoryList cat = new categoryList();
            cat.TopLevel = false;
            cat.FormBorderStyle = FormBorderStyle.None;
            cat.Dock = DockStyle.Fill;
            admin_main_panel.Controls.Add(cat);
            admin_main_panel.Tag = cat;
            cat.BringToFront();
            cat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCashier frmCash = new frmCashier();
            frmCash.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            admin_main_panel.Controls.Clear();

            frmSales sls = new frmSales();
            sls.TopLevel = false;
            sls.FormBorderStyle = FormBorderStyle.None;
            sls.Dock = DockStyle.Fill;
            admin_main_panel.Controls.Add(sls);
            admin_main_panel.Tag = sls;
            sls.BringToFront();
            sls.Show();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            frmAddUsers addUser = new frmAddUsers();
            addUser.TopLevel = false;
            addUser.FormBorderStyle = FormBorderStyle.None;
            addUser.Dock = DockStyle.Fill;
            admin_main_panel.Controls.Add(addUser);
            admin_main_panel.Tag = addUser;
            addUser.BringToFront();
            addUser.Show();

        }
    }
}
