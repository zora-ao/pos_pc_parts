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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            dataGridView1 = new DataGridView();
            transId = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colPayment = new DataGridViewTextBoxColumn();
            colCashier = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            sortDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            btnLoadAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { transId, colTotal, colPayment, colCashier, colDate });
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(780, 325);
            dataGridView1.TabIndex = 0;
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
            // sortDate
            // 
            sortDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sortDate.Content = new DateTime(2025, 12, 5, 0, 0, 0, 0);
            sortDate.EnableThemeChangeButton = true;
            sortDate.Font = new Font("Segoe UI", 9.75F);
            sortDate.ForeColor = Color.Gray;
            sortDate.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            sortDate.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            sortDate.Icon = (Image)resources.GetObject("sortDate.Icon");
            sortDate.IconTint = Color.Gray;
            sortDate.Location = new Point(308, 77);
            sortDate.Margin = new Padding(4, 3, 4, 3);
            sortDate.Name = "sortDate";
            sortDate.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            sortDate.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            sortDate.OutlineThickness = 1.5F;
            sortDate.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            sortDate.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            sortDate.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            sortDate.Rounding = 8;
            sortDate.ShowIcon = true;
            sortDate.Size = new Size(153, 28);
            sortDate.TabIndex = 2;
            sortDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            sortDate.Load += sortDate_Load;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Date\\ by:";
            cuiLabel2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(221, 79);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(79, 26);
            cuiLabel2.TabIndex = 3;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // btnLoadAll
            // 
            btnLoadAll.Location = new Point(564, 77);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(93, 29);
            btnLoadAll.TabIndex = 4;
            btnLoadAll.Text = "View All";
            btnLoadAll.UseVisualStyleBackColor = true;
            btnLoadAll.Click += btnLoadAll_Click;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(btnLoadAll);
            Controls.Add(cuiLabel2);
            Controls.Add(sortDate);
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
        private CuoreUI.Controls.cuiCalendarDatePicker sortDate;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private Button btnLoadAll;
    }
}