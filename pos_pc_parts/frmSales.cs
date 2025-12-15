using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_pc_parts
{
    public partial class frmSales : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection dbcon = new DBConnection();
        public frmSales()
        {
            InitializeComponent();
            sortDate.DateChanged += (s, e) => filterByDate();
        }


        public void filterByDate()
        {
            dataGridView1.Rows.Clear();

            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();

            DateTime start = sortDate.Content.Date;
            DateTime end = sortDate.Content.Date.AddDays(1).AddSeconds(-1);

            string query = @"
                SELECT t.transaction_id, t.total, t.payment_type, t.date_sold, u.name AS cashier_name
                FROM transactions t
                JOIN users u ON t.cashier_id = u.user_id
                WHERE t.date_sold BETWEEN @start AND @end
            ";

            cm = new MySqlCommand(query, cn);
            cm.Parameters.AddWithValue("@start", start);
            cm.Parameters.AddWithValue("@end", end);

            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(
                    dr["transaction_id"].ToString(),
                    dr["total"].ToString(),
                    dr["payment_type"].ToString(),
                    dr["cashier_name"].ToString(),
                    dr["date_sold"].ToString()
                );
            }

            dr.Close();
            cn.Close();

        }

        private void sortDate_Load(object sender, EventArgs e)
        {
            filterByDate();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();

            string query = @"
            SELECT t.transaction_id, t.total, t.payment_type, t.date_sold, u.name AS cashier_name
            FROM transactions t
            JOIN users u ON t.cashier_id = u.user_id";

            cm = new MySqlCommand(query, cn);
            MySqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(
                    dr["transaction_id"].ToString(),
                    dr["total"].ToString(),
                    dr["payment_type"].ToString(),
                    dr["cashier_name"].ToString(),
                    dr["date_sold"].ToString()
                    );
            }
            dr.Close();
            cn.Close();

        }
    }
}
