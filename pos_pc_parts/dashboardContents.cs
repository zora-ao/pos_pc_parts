using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

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
            countStocks();
            todaySales();
            overAllSales();
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

        public void countStocks()
        {
            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();

            cm = new MySqlCommand("SELECT SUM(quantity) FROM products", cn);
            int totalStocks = Convert.ToInt32(cm.ExecuteScalar());
            lbTotalStock.Text = totalStocks.ToString();


            cn.Close();
        }

        public void todaySales()
        {
            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();
            cm = new MySqlCommand("SELECT SUM(total) FROM transactions WHERE DATE(date_sold) = CURDATE()", cn);
            object result = cm.ExecuteScalar();

            decimal totalSales = (result == DBNull.Value || result == null) ? 0 : Convert.ToDecimal(result);
            lbSalesToday.Text = totalSales.ToString("C2");
            cn.Close();
        }

        public void overAllSales()
        {
            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();
            cm = new MySqlCommand("SELECT SUM(total) FROM transactions", cn);
            object result = cm.ExecuteScalar();
            decimal totalSales = (result == DBNull.Value || result == null) ? 0 : Convert.ToDecimal(result);
            lbOverallSales.Text = totalSales.ToString("C2");
            cn.Close();
        }


    }
}
