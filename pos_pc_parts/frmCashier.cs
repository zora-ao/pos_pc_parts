using MySql.Data.MySqlClient;
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
    public partial class frmCashier : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection dbcon = new DBConnection();
        public frmCashier()
        {
            InitializeComponent();

            Button[] numberButtons = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            foreach (Button btn in numberButtons)
            {
                btn.Click += btnNumber_Click;
            }


            loadProducts();
            LoadPendingItems();
        }

        public void loadProducts()
        {
            flowLayoutPanel1.Controls.Clear();

            cn = new MySqlConnection(dbcon.GetConnection());
            cn.Open();

            string query = "SELECT product_id, product_name, image_path, price FROM products";

            cm = new MySqlCommand(query, cn);
            MySqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                int cardSize = 120;


                Panel card = new Panel();
                card.Width = cardSize;
                card.Height = cardSize;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Cursor = Cursors.Hand;
                card.Tag = dr["product_id"].ToString();


                PictureBox pic = new PictureBox();
                pic.Dock = DockStyle.Fill;
                pic.SizeMode = PictureBoxSizeMode.Zoom;

                string imgPath = Path.Combine(Application.StartupPath, "Images", dr["image_path"].ToString());
                if (File.Exists(imgPath))
                {
                    pic.Image = Image.FromFile(imgPath);
                }

                card.Controls.Add(pic);

                Label lblName = new Label();
                lblName.Text = dr["product_name"].ToString();
                lblName.ForeColor = Color.White;
                lblName.BackColor = Color.FromArgb(180, 0, 0, 0);
                lblName.Dock = DockStyle.Top;
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                lblName.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                lblName.Height = 20;

                card.Controls.Add(lblName);


                Panel overlay = new Panel();
                overlay.Height = 20;
                overlay.Dock = DockStyle.Bottom;
                overlay.BackColor = Color.FromArgb(180, 0, 0, 0);


                Label lblPrice = new Label();
                lblPrice.Text = "₱ " + Convert.ToDecimal(dr["price"]).ToString("N2");
                lblPrice.ForeColor = Color.White;
                lblPrice.Dock = DockStyle.Fill;
                lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                lblPrice.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                overlay.Controls.Add(lblPrice);

                card.Controls.Add(overlay);



                card.Click += Card_Click;
                foreach (Control ctrl in card.Controls)
                {
                    ctrl.Click += (s, e) => Card_Click(card, e);

                }


                flowLayoutPanel1.Controls.Add(card);
            }


            dr.Close();


            cn.Close();

        }

        public int currentCashierId = 1;
        public void Card_Click(object sender, EventArgs e)
        {
            Panel card = (Panel)sender;

            string id = card.Tag.ToString();

            if (MessageBox.Show("Do you want to add this?", "Add Product",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn = new MySqlConnection(dbcon.GetConnection());
                cn.Open();

                // 1️⃣ Check if product already exists in pending_items
                string checkQuery = "SELECT COUNT(*) FROM pending_items WHERE cashier_id = @cashier AND product_id = @product_id";
                cm = new MySqlCommand(checkQuery, cn);
                cm.Parameters.AddWithValue("@cashier", currentCashierId);
                cm.Parameters.AddWithValue("@product_id", id);

                int count = Convert.ToInt32(cm.ExecuteScalar());

                if (count > 0)
                {
                    // 2️⃣ If exists → increase quantity
                    cm = new MySqlCommand(
                        "UPDATE pending_items SET quantity = quantity + 1WHERE cashier_id = @cashier AND product_id = @product;", cn);

                    cm.Parameters.AddWithValue("@cashier", currentCashierId);
                    cm.Parameters.AddWithValue("@product_id", id);
                    cm.ExecuteNonQuery();
                }
                else
                {
                    // 3️⃣ If not exists → insert new row
                    cm = new MySqlCommand(
                        "INSERT INTO pending_items (cashier_id, product_id, quantity, price, su) " +
                        "VALUES (@cashier, @product_id, 1, (SELECT price FROM products WHERE product_id = @product_id), " +
                        "(SELECT price FROM products WHERE product_id = @product_id))", cn);

                    cm.Parameters.AddWithValue("@cashier", currentCashierId);
                    cm.Parameters.AddWithValue("@product_id", id);
                    cm.ExecuteNonQuery();
                }

                cn.Close();

                LoadPendingItems();  // refresh UI
            }

        }
        public void LoadPendingItems()
        {
            try
            {
                dataGridViewCart.Rows.Clear();
                cn = new MySqlConnection(dbcon.GetConnection());
                cn.Open();

                string query = "SELECT p.product_name, pi.quantity, pi.price, pi.subtotal " +
                               "FROM pending_items pi " +
                               "JOIN products p ON pi.product_id = p.product_id " +
                               "WHERE pi.cashier_id = @cashier";

                cm = new MySqlCommand(query, cn);
                cm.Parameters.AddWithValue("@cashier", currentCashierId);

                MySqlDataReader dr = cm.ExecuteReader();

                decimal subTotals = 0;

                while (dr.Read())
                {
                    dataGridViewCart.Rows.Add(
                        dr["product_name"].ToString(),
                        dr["quantity"].ToString(),
                        Convert.ToDecimal(dr["price"]).ToString("N2")
                        );
                    subTotals += Convert.ToDecimal(dr["subtotal"]);
                }

                txtSubTotal.Text = subTotals.ToString();



                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtAmount.Text += btn.Text;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtAmount.Text.Contains("."))
            {
                if (txtAmount.Text == "")
                    txtAmount.Text = "0.";
                else
                    txtAmount.Text += ".";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length > 0)
                txtAmount.Text = txtAmount.Text.Remove(txtAmount.Text.Length - 1);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Amount entered: ₱ " + amount.ToString("N2"));

                if (amount < Convert.ToDecimal(txtSubTotal.Text))
                {
                    MessageBox.Show("Insufficient amount!");
                    return;
                }

                if (amount == Convert.ToDecimal(txtSubTotal.Text))
                {
                    lbCustomerChanged.Text = "Change: ₱ 0.00";
                    return;
                }

                if (comboPayment.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a payment method.");
                    return;
                }

                lbCutomerMoney.Text = amount.ToString("N2");
                txtAmount.Text = "";

                decimal change = amount - Convert.ToDecimal(txtSubTotal.Text);
                lbCustomerChanged.Text = change.ToString();
            }
            else
            {
                MessageBox.Show("Invalid amount!");
            }
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewCart.Columns[e.ColumnIndex].Name;

            if (colName == "colIncrease")
            {
                cn = new MySqlConnection(dbcon.GetConnection());
                cn.Open();

                cm = new MySqlCommand("UPDATE pending_items SET quantity = quantity + 1 WHERE cashier_id = @cashier AND product_id = (SELECT product_id FROM products WHERE product_name = @product_name)", cn);
                cm.Parameters.AddWithValue("@cashier", currentCashierId);
                cm.Parameters.AddWithValue("@product_name", dataGridViewCart.Rows[e.RowIndex].Cells[0].Value.ToString());
                cm.ExecuteNonQuery();
                cn.Close();

                LoadPendingItems();

            }
            else if (colName == "colDecrease")
            {
                cn = new MySqlConnection(dbcon.GetConnection());
                cn.Open();
                cm = new MySqlCommand("UPDATE pending_items SET quantity = quantity - 1 WHERE cashier_id = @cashier AND product_id = (SELECT product_id FROM products WHERE product_name = @product_name)", cn);
                cm.Parameters.AddWithValue("@cashier", currentCashierId);
                cm.Parameters.AddWithValue("@product_name", dataGridViewCart.Rows[e.RowIndex].Cells[0].Value.ToString());
                cm.ExecuteNonQuery();
                cm = new MySqlCommand("DELETE FROM pending_items WHERE cashier_id = @cashier AND quantity <= 0", cn);
                cm.Parameters.AddWithValue("@cashier", currentCashierId);
                cm.ExecuteNonQuery();
                cn.Close();

                LoadPendingItems();

            }
        }
    }
}
