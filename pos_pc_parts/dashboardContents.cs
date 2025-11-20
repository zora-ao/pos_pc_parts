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
            loadProducts();
            CountProducts();
        }


        public void loadProducts()
        {
            cn = new MySqlConnection(dbcon.GetConnection());

            cn.Open();

            cm = new MySqlCommand("SELECT * FROM products", cn);

            MySqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(
                    dr["product_id"].ToString(),
                    dr["product_name"].ToString(),
                    dr["category"].ToString(),
                    dr["price"].ToString(),
                    dr["quantity"].ToString()
                    );
            }

            dr.Close();


            cn.Close();

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
