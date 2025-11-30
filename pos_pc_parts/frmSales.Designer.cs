namespace pos_pc_parts
{
    partial class frmSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            transId = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colPayment = new DataGridViewTextBoxColumn();
            colCashier = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { transId, colTotal, colPayment, colCashier, colDate });
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 325);
            dataGridView1.TabIndex = 0;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Sales";
            cuiLabel1.Font = new Font("Rockwell Nova", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(13, 12);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(87, 20);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // transId
            // 
            transId.HeaderText = "Transaction";
            transId.Name = "transId";
            transId.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colPayment
            // 
            colPayment.HeaderText = "Payment";
            colPayment.Name = "colPayment";
            colPayment.ReadOnly = true;
            // 
            // colCashier
            // 
            colCashier.HeaderText = "Cashier";
            colCashier.Name = "colCashier";
            colCashier.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cuiLabel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSales";
            Text = "frmSales";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private DataGridViewTextBoxColumn transId;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colPayment;
        private DataGridViewTextBoxColumn colCashier;
        private DataGridViewTextBoxColumn colDate;
    }
}