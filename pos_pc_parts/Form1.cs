using MySql.Data.MySqlClient;

namespace pos_pc_parts
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
