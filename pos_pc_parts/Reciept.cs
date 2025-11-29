using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using iTextFont = iTextSharp.text.Font;
using iTextSharp.text.pdf.draw;
using PdfiumViewer;

namespace pos_pc_parts
{

    public class ReceiptGenerator
    {
        private DBConnection dbcon = new DBConnection();

        public void GenerateReceipt(int transactionId, int cashierId, string filePath)
        {
            using (var cn = new MySqlConnection(dbcon.GetConnection()))
            {
                cn.Open();
                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                doc.Add(new Paragraph("EZPC", new iTextFont(iTextFont.FontFamily.HELVETICA, 18, iTextFont.BOLD)) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph("======================================"));

                MySqlCommand cm = new MySqlCommand(
                    "SELECT p.product_name, ti.quantity, ti.price, ti.subtotal FROM transaction_items ti JOIN products p ON ti.product_id=p.product_id WHERE ti.transaction_id=@trans", cn);
                cm.Parameters.AddWithValue("@trans", transactionId);

                MySqlDataReader dr = cm.ExecuteReader();

                PdfPTable table = new PdfPTable(4) { WidthPercentage = 100 };
                table.SetWidths(new float[] { 3, 1, 1, 1 });
                table.AddCell("Product"); table.AddCell("Qty"); table.AddCell("Price"); table.AddCell("Total");

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
                doc.Add(new Paragraph($"TOTAL: ₱ {total:N2}"));
                doc.Close();
            }
        }
    }

}
