using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextFont = iTextSharp.text.Font;
using iTextSharp.text.pdf.draw;
using PdfiumViewer;
using System.IO;
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
                    pic.Image = System.Drawing.Image.FromFile(imgPath);
                }

                card.Controls.Add(pic);

                Label lblName = new Label();
                lblName.Text = dr["product_name"].ToString();
                lblName.ForeColor = Color.White;
                lblName.BackColor = Color.FromArgb(180, 0, 0, 0);
                lblName.Dock = DockStyle.Top;
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                lblName.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
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
                lblPrice.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);


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


                string checkQuery = "SELECT COUNT(*) FROM pending_items WHERE cashier_id = @cashier AND product_id = @product_id";
                cm = new MySqlCommand(checkQuery, cn);
                cm.Parameters.AddWithValue("@cashier", currentCashierId);
                cm.Parameters.AddWithValue("@product_id", id);

                int count = Convert.ToInt32(cm.ExecuteScalar());

                if (count > 0)
                {

                    cm = new MySqlCommand(
                        "UPDATE pending_items SET quantity = quantity + 1 WHERE cashier_id = @cashier AND product_id = @product_id;", cn);

                    cm.Parameters.AddWithValue("@cashier", currentCashierId);
                    cm.Parameters.AddWithValue("@product_id", id);
                    cm.ExecuteNonQuery();
                }
                else
                {

                    cm = new MySqlCommand(
                        "INSERT INTO pending_items (cashier_id, product_id, quantity, price) " +
                        "VALUES (@cashier, @product_id, 1, (SELECT price FROM products WHERE product_id = @product_id))",
                        cn
                    );


                    cm.Parameters.AddWithValue("@cashier", currentCashierId);
                    cm.Parameters.AddWithValue("@product_id", id);
                    cm.ExecuteNonQuery();
                }

                cn.Close();

                LoadPendingItems();
            }

        }
        public void LoadPendingItems()
        {
            try
            {
                dataGridViewCart.Rows.Clear();
                cn = new MySqlConnection(dbcon.GetConnection());
                cn.Open();

                string query = "SELECT pi.id ,p.product_name, pi.quantity, pi.price, pi.subtotal " +
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
                        dr["id"].ToString(),
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


                lbCutomerMoney.Text = amount.ToString("N2");
                txtAmount.Text = "";

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
                cm.Parameters.AddWithValue("@product_name", dataGridViewCart.Rows[e.RowIndex].Cells[1].Value.ToString());
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
                cm.Parameters.AddWithValue("@product_name", dataGridViewCart.Rows[e.RowIndex].Cells[1].Value.ToString());
                cm.ExecuteNonQuery();
                cm = new MySqlCommand("DELETE FROM pending_items WHERE cashier_id = @cashier AND quantity <= 0", cn);
                cm.Parameters.AddWithValue("@cashier", currentCashierId);
                cm.ExecuteNonQuery();
                cn.Close();

                LoadPendingItems();

            }
        }

        private void button17_Click(object sender, EventArgs e) // this is the delete nalimutan ko e rename
        {
            if (dataGridViewCart.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to delete.", "Delete Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pendingId = dataGridViewCart.CurrentRow.Cells["colId"].Value.ToString();

            if (MessageBox.Show("Are you sure you want to delete this item?",
                "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn = new MySqlConnection(dbcon.GetConnection());
                cn.Open();

                string query = "DELETE FROM pending_items WHERE id = @id";
                MySqlCommand cm = new MySqlCommand(query, cn);
                cm.Parameters.AddWithValue("@id", pendingId);
                cm.ExecuteNonQuery();

                cn.Close();

                LoadPendingItems();
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection(dbcon.GetConnection());

            cn.Open();

            cm = new MySqlCommand("DELETE FROM pending_items WHERE cashier_id = @cashier", cn);
            cm.Parameters.AddWithValue("@cashier", currentCashierId);
            cm.ExecuteNonQuery();

            MessageBox.Show("Cart cleared successfully.", "Clear Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadPendingItems();
            cn.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

          
            if (decimal.TryParse(lbCutomerMoney.Text, out decimal amount))
            {

                decimal change = amount - Convert.ToDecimal(txtSubTotal.Text);

                if (amount < Convert.ToDecimal(txtSubTotal.Text) || Convert.ToDecimal(txtSubTotal.Text) <= 0)
                {
                    MessageBox.Show("Insufficient amount!");
                    return;
                }

                if (amount == Convert.ToDecimal(txtSubTotal.Text))
                {
                    
                    lbCustomerChanged.Text = change.ToString("N2");
                }

                if (comboPayment.SelectedIndex == -1 || comboPayment.SelectedItem == null)
                {
                    MessageBox.Show("Please select a payment method.");
                    return;
                }


                lbCutomerMoney.Text = amount.ToString("N2");
                txtAmount.Text = "";

                lbCustomerChanged.Text = change.ToString();

                cn = new MySqlConnection(dbcon.GetConnection());
                cn.Open();

                cm = new MySqlCommand(
                    "INSERT INTO transactions (cashier_id, total, payment_type, date_sold) " +
                    "VALUES (@cashier, @total, @payment, NOW()); SELECT LAST_INSERT_ID();",
                    cn
                );
                cm.Parameters.AddWithValue("@cashier", currentCashierId);
                cm.Parameters.AddWithValue("@total", Convert.ToDecimal(txtSubTotal.Text));
                cm.Parameters.AddWithValue("@payment", comboPayment.SelectedItem.ToString());
                int transactionId = Convert.ToInt32(cm.ExecuteScalar());

                cm = new MySqlCommand(
                    "INSERT INTO transaction_items (transaction_id, product_id, quantity, price) " +
                    "SELECT @trans_id, product_id, quantity, price FROM pending_items WHERE cashier_id = @cashier",
                    cn
                );
                cm.Parameters.AddWithValue("@trans_id", transactionId);
                cm.Parameters.AddWithValue("@cashier", currentCashierId);
                cm.ExecuteNonQuery();

                cm = new MySqlCommand("DELETE FROM pending_items WHERE cashier_id = @cashier", cn);
                cm.Parameters.AddWithValue("@cashier", currentCashierId);
                cm.ExecuteNonQuery();
                MessageBox.Show("Payment successful! Transaction ID: " + transactionId, "Payment",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                cn.Close();


                LoadPendingItems();

                string paymentMethod = comboPayment.SelectedItem?.ToString() ?? "Unknown";
                GenerateReceipt(transactionId, paymentMethod);

                lbCutomerMoney.Text = "0.00";
                lbCustomerChanged.Text = "0.00";


            }
            else
            {
                MessageBox.Show("Invalid amount!");
            }
        }

        private void GenerateReceipt(int transactionId, string paymentType)
        {
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, "Receipts");
                Directory.CreateDirectory(folderPath);

                string fileName = Path.Combine(folderPath, "receipt_" + transactionId + ".pdf");

                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));

                doc.Open();

                
                iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph(
                    "EZPC\n",
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
                );
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph("======================================"));
                doc.Add(new Paragraph("Transaction ID: " + transactionId));
                doc.Add(new Paragraph("Date: " + DateTime.Now));
                doc.Add(new Paragraph("Cashier ID: " + currentCashierId));
                doc.Add(new Paragraph("--------------------------------------"));

                
                cn = new MySqlConnection(dbcon.GetConnection());
                cn.Open();

                MySqlCommand cm2 = new MySqlCommand(
                    "SELECT p.product_name, ti.quantity, ti.price, ti.subtotal " +
                    "FROM transaction_items ti JOIN products p ON ti.product_id = p.product_id " +
                    "WHERE ti.transaction_id = @trans", cn);

                cm2.Parameters.AddWithValue("@trans", transactionId);
                MySqlDataReader dr = cm2.ExecuteReader();

                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 3, 1, 1, 1 });

                table.AddCell("Product");
                table.AddCell("Qty");
                table.AddCell("Price");
                table.AddCell("Total");

                decimal total = 0;

                while (dr.Read())
                {
                    table.AddCell(dr["product_name"].ToString());
                    table.AddCell(dr["quantity"].ToString());
                    table.AddCell("₱" + Convert.ToDecimal(dr["price"]).ToString("N2"));
                    table.AddCell("₱" + Convert.ToDecimal(dr["subtotal"]).ToString("N2"));

                    total += Convert.ToDecimal(dr["subtotal"]);
                }

                doc.Add(table);

                dr.Close();
                cn.Close();

                doc.Add(new Paragraph("--------------------------------------"));
                doc.Add(new Paragraph($"TOTAL: ₱ {total:N2}"));
                doc.Add(new Paragraph($"{paymentType}: ₱ {lbCutomerMoney.Text}"));
                doc.Add(new Paragraph($"CHANGE: ₱ {lbCustomerChanged.Text}"));
                doc.Add(new Paragraph("======================================"));
                doc.Add(new iTextSharp.text.Paragraph(
                    "THANK YOU FOR YOUR PURCHASE!",
                    new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD)
                ));

                doc.Close();

                cn.Close();

         
                using (var pdfDoc = PdfiumViewer.PdfDocument.Load(fileName))
                {
                    Form previewForm = new Form();
                    previewForm.Text = "Receipt Preview";
                    previewForm.Width = 600;
                    previewForm.Height = 800;

                    PdfiumViewer.PdfViewer pdfViewer = new PdfiumViewer.PdfViewer();
                    pdfViewer.Dock = DockStyle.Fill;
                    pdfViewer.Document = pdfDoc;

                    previewForm.Controls.Add(pdfViewer);
                    previewForm.ShowDialog(); 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PDF Error");
            }

        }


    }
}
