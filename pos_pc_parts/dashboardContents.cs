using MySql.Data.MySqlClient;

namespace pos_pc_parts
{
    public partial class dashboardContents : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection dbcon = new DBConnection();
        public dashboardContents()
        {
            InitializeComponent();
            CountProducts();
        }


      
        public void CountProducts()
        {
            cn = new MySqlConnection(dbcon.GetConnection());

            cn.Open();

            cm = new MySqlCommand("SELECT COUNT(*) FROM products", cn);

            int total = Convert.ToInt32(cm.ExecuteScalar());
            lbTotalItems.Text = total.ToString();

            cn.Close();


        }


    }
}
