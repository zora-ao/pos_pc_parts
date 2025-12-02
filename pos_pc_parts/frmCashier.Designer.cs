namespace pos_pc_parts
{
    partial class frmCashier
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            lbCashierName = new CuoreUI.Controls.cuiLabel();
            panel4 = new Panel();
            button19 = new Button();
            button17 = new Button();
            btnClearCart = new Button();
            btnPay = new Button();
            panel7 = new Panel();
            comboPayment = new CuoreUI.Controls.cuiComboBox();
            lbCustomerChanged = new Label();
            lbCutomerMoney = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            txtSubTotal = new CuoreUI.Controls.cuiTextBox();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            dataGridViewCart = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colIncrease = new DataGridViewImageColumn();
            colDecrease = new DataGridViewImageColumn();
            panel3 = new Panel();
            txtAmount = new CuoreUI.Controls.cuiTextBox();
            btnEnter = new Button();
            btnBack = new Button();
            btnClear = new Button();
            btn7 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btnDecimal = new Button();
            btn9 = new Button();
            btn4 = new Button();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(cuiLabel2);
            panel2.Controls.Add(lbCashierName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 46);
            panel2.TabIndex = 1;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Cashier:";
            cuiLabel2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            cuiLabel2.ForeColor = Color.White;
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(15, 12);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(84, 23);
            cuiLabel2.TabIndex = 1;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // lbCashierName
            // 
            lbCashierName.Content = "Jose";
            lbCashierName.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lbCashierName.ForeColor = Color.White;
            lbCashierName.HorizontalAlignment = StringAlignment.Center;
            lbCashierName.Location = new Point(91, 12);
            lbCashierName.Margin = new Padding(4, 3, 4, 3);
            lbCashierName.Name = "lbCashierName";
            lbCashierName.Size = new Size(62, 23);
            lbCashierName.TabIndex = 1;
            lbCashierName.VerticalAlignment = StringAlignment.Near;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Controls.Add(button19);
            panel4.Controls.Add(button17);
            panel4.Controls.Add(btnClearCart);
            panel4.Controls.Add(btnPay);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 374);
            panel4.Name = "panel4";
            panel4.Size = new Size(996, 137);
            panel4.TabIndex = 1;
            // 
            // button19
            // 
            button19.Anchor = AnchorStyles.Right;
            button19.BackColor = Color.Transparent;
            button19.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.ForeColor = Color.Maroon;
            button19.Image = Properties.Resources.vaadin_exit_o;
            button19.Location = new Point(943, 71);
            button19.Name = "button19";
            button19.Size = new Size(53, 66);
            button19.TabIndex = 4;
            button19.Text = "Exit";
            button19.TextImageRelation = TextImageRelation.TextAboveImage;
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button17
            // 
            button17.Anchor = AnchorStyles.Bottom;
            button17.BackColor = Color.IndianRed;
            button17.FlatAppearance.CheckedBackColor = Color.Silver;
            button17.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button17.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Image = Properties.Resources.mdi_cart_remove;
            button17.ImageAlign = ContentAlignment.BottomCenter;
            button17.Location = new Point(704, 36);
            button17.Name = "button17";
            button17.Size = new Size(75, 82);
            button17.TabIndex = 4;
            button17.Text = "Remove";
            button17.TextAlign = ContentAlignment.BottomCenter;
            button17.TextImageRelation = TextImageRelation.ImageAboveText;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearCart.BackColor = Color.YellowGreen;
            btnClearCart.FlatAppearance.CheckedBackColor = Color.Silver;
            btnClearCart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClearCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCart.Image = Properties.Resources.tdesign_clear;
            btnClearCart.ImageAlign = ContentAlignment.BottomCenter;
            btnClearCart.Location = new Point(806, 36);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(75, 82);
            btnClearCart.TabIndex = 4;
            btnClearCart.Text = "Clear";
            btnClearCart.TextAlign = ContentAlignment.BottomCenter;
            btnClearCart.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPay.BackColor = Color.Khaki;
            btnPay.FlatAppearance.CheckedBackColor = Color.Silver;
            btnPay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPay.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.Image = Properties.Resources.arcticons_mts_pay;
            btnPay.Location = new Point(602, 36);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(75, 82);
            btnPay.TabIndex = 4;
            btnPay.Text = "Pay";
            btnPay.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.SlateGray;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(comboPayment);
            panel7.Controls.Add(lbCustomerChanged);
            panel7.Controls.Add(lbCutomerMoney);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Left;
            panel7.Font = new Font("Microsoft Sans Serif", 12F);
            panel7.Location = new Point(320, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(262, 137);
            panel7.TabIndex = 3;
            // 
            // comboPayment
            // 
            comboPayment.BackgroundColor = Color.FromArgb(255, 255, 255);
            comboPayment.DropDownBackgroundColor = Color.White;
            comboPayment.DropDownForeColor = Color.FromArgb(27, 27, 27);
            comboPayment.ExpandArrowColor = Color.Gray;
            comboPayment.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboPayment.ForeColor = Color.Black;
            comboPayment.Items = new string[]
    {
    "Cash",
    "Gcash",
    "Paymaya",
    "Credit"
    };
            comboPayment.Location = new Point(114, 22);
            comboPayment.Margin = new Padding(6, 4, 6, 4);
            comboPayment.Name = "comboPayment";
            comboPayment.NoSelectionText = "None";
            comboPayment.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            comboPayment.OutlineThickness = 1F;
            comboPayment.Rounding = 5;
            comboPayment.SelectedIndex = -1;
            comboPayment.SelectedItem = "";
            comboPayment.Size = new Size(101, 36);
            comboPayment.SortAlphabetically = true;
            comboPayment.TabIndex = 3;
            // 
            // lbCustomerChanged
            // 
            lbCustomerChanged.AutoSize = true;
            lbCustomerChanged.Font = new Font("Microsoft Sans Serif", 12F);
            lbCustomerChanged.Location = new Point(114, 97);
            lbCustomerChanged.Name = "lbCustomerChanged";
            lbCustomerChanged.Size = new Size(40, 20);
            lbCustomerChanged.TabIndex = 2;
            lbCustomerChanged.Text = "0.00";
            // 
            // lbCutomerMoney
            // 
            lbCutomerMoney.AutoSize = true;
            lbCutomerMoney.Font = new Font("Microsoft Sans Serif", 12F);
            lbCutomerMoney.Location = new Point(114, 65);
            lbCutomerMoney.Name = "lbCutomerMoney";
            lbCutomerMoney.Size = new Size(40, 20);
            lbCutomerMoney.TabIndex = 2;
            lbCutomerMoney.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label7.Location = new Point(31, 97);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 1;
            label7.Text = "Change:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label6.Location = new Point(39, 65);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 1;
            label6.Text = "Money:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label5.Location = new Point(29, 28);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 1;
            label5.Text = "Payment: ";
            // 
            // panel6
            // 
            panel6.BackColor = Color.SlateGray;
            panel6.Controls.Add(cuiTextBox1);
            panel6.Controls.Add(txtSubTotal);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(320, 137);
            panel6.TabIndex = 2;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.FocusOutlineColor = Color.FromArgb(224, 224, 224);
            cuiTextBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Black;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(100, 67);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox1.Padding = new Padding(16, 7, 16, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.LightGray;
            cuiTextBox1.PlaceholderText = "";
            cuiTextBox1.Rounding = new Padding(5);
            cuiTextBox1.Size = new Size(175, 31);
            cuiTextBox1.TabIndex = 2;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = true;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackgroundColor = Color.White;
            txtSubTotal.Content = "";
            txtSubTotal.FocusBackgroundColor = Color.White;
            txtSubTotal.FocusImageTint = Color.White;
            txtSubTotal.FocusOutlineColor = Color.FromArgb(224, 224, 224);
            txtSubTotal.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubTotal.ForeColor = Color.Black;
            txtSubTotal.Image = null;
            txtSubTotal.ImageExpand = new Point(0, 0);
            txtSubTotal.ImageOffset = new Point(0, 0);
            txtSubTotal.Location = new Point(100, 28);
            txtSubTotal.Margin = new Padding(4);
            txtSubTotal.Multiline = false;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.NormalImageTint = Color.White;
            txtSubTotal.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtSubTotal.Padding = new Padding(16, 7, 16, 0);
            txtSubTotal.PasswordChar = false;
            txtSubTotal.PlaceholderColor = Color.LightGray;
            txtSubTotal.PlaceholderText = "";
            txtSubTotal.Rounding = new Padding(5);
            txtSubTotal.Size = new Size(175, 31);
            txtSubTotal.TabIndex = 2;
            txtSubTotal.TextOffset = new Size(0, 0);
            txtSubTotal.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label4.Location = new Point(48, 76);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 1;
            label4.Text = "Tax: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label3.Location = new Point(15, 33);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 1;
            label3.Text = "Sub Total:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewCart);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 328);
            panel1.TabIndex = 2;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.AllowUserToAddRows = false;
            dataGridViewCart.AllowUserToDeleteRows = false;
            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCart.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCart.BorderStyle = BorderStyle.None;
            dataGridViewCart.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colQuantity, colPrice, colIncrease, colDecrease });
            dataGridViewCart.Dock = DockStyle.Fill;
            dataGridViewCart.GridColor = Color.IndianRed;
            dataGridViewCart.Location = new Point(0, 0);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.ReadOnly = true;
            dataGridViewCart.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewCart.Size = new Size(359, 328);
            dataGridViewCart.TabIndex = 0;
            dataGridViewCart.CellContentClick += dataGridViewCart_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colName
            // 
            dataGridViewCellStyle2.BackColor = Color.Lime;
            colName.DefaultCellStyle = dataGridViewCellStyle2;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colQuantity.HeaderText = "Qty";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 51;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colIncrease
            // 
            colIncrease.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colIncrease.HeaderText = "";
            colIncrease.Image = Properties.Resources.plus_circle;
            colIncrease.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colIncrease.Name = "colIncrease";
            colIncrease.ReadOnly = true;
            colIncrease.Width = 5;
            // 
            // colDecrease
            // 
            colDecrease.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colDecrease.HeaderText = "";
            colDecrease.Image = Properties.Resources.minus_circle;
            colDecrease.Name = "colDecrease";
            colDecrease.ReadOnly = true;
            colDecrease.Width = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtAmount);
            panel3.Controls.Add(btnEnter);
            panel3.Controls.Add(btnBack);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btn7);
            panel3.Controls.Add(btn2);
            panel3.Controls.Add(btn3);
            panel3.Controls.Add(btn1);
            panel3.Controls.Add(btn0);
            panel3.Controls.Add(btn6);
            panel3.Controls.Add(btn5);
            panel3.Controls.Add(btn8);
            panel3.Controls.Add(btnDecimal);
            panel3.Controls.Add(btn9);
            panel3.Controls.Add(btn4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(775, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 328);
            panel3.TabIndex = 3;
            // 
            // txtAmount
            // 
            txtAmount.BackgroundColor = Color.White;
            txtAmount.Content = "";
            txtAmount.FocusBackgroundColor = Color.White;
            txtAmount.FocusImageTint = Color.White;
            txtAmount.FocusOutlineColor = Color.DarkKhaki;
            txtAmount.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.ForeColor = Color.Black;
            txtAmount.Image = null;
            txtAmount.ImageExpand = new Point(0, 0);
            txtAmount.ImageOffset = new Point(0, 0);
            txtAmount.Location = new Point(16, 6);
            txtAmount.Margin = new Padding(4);
            txtAmount.Multiline = false;
            txtAmount.Name = "txtAmount";
            txtAmount.NormalImageTint = Color.White;
            txtAmount.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtAmount.Padding = new Padding(21, 5, 21, 0);
            txtAmount.PasswordChar = false;
            txtAmount.PlaceholderColor = Color.LightGray;
            txtAmount.PlaceholderText = "Amount";
            txtAmount.Rounding = new Padding(8);
            txtAmount.Size = new Size(191, 31);
            txtAmount.TabIndex = 1;
            txtAmount.TextOffset = new Size(0, 0);
            txtAmount.UnderlinedStyle = true;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Khaki;
            btnEnter.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnEnter.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnEnter.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btnEnter.Location = new Point(30, 268);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(108, 47);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Khaki;
            btnBack.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnBack.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnBack.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btnBack.Location = new Point(154, 265);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 50);
            btnBack.TabIndex = 1;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnClear.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnClear.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btnClear.Location = new Point(154, 212);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(46, 50);
            btnClear.TabIndex = 1;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Khaki;
            btn7.Cursor = Cursors.Cross;
            btn7.FlatAppearance.BorderColor = Color.Red;
            btn7.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btn7.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn7.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn7.Location = new Point(30, 44);
            btn7.Name = "btn7";
            btn7.Size = new Size(46, 50);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Khaki;
            btn2.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn2.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn2.Location = new Point(92, 156);
            btn2.Name = "btn2";
            btn2.Size = new Size(46, 50);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Khaki;
            btn3.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn3.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn3.Location = new Point(154, 156);
            btn3.Name = "btn3";
            btn3.Size = new Size(46, 50);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Khaki;
            btn1.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn1.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn1.Location = new Point(30, 156);
            btn1.Name = "btn1";
            btn1.Size = new Size(46, 50);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Khaki;
            btn0.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn0.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn0.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn0.Location = new Point(30, 212);
            btn0.Name = "btn0";
            btn0.Size = new Size(46, 50);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Khaki;
            btn6.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn6.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn6.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn6.Location = new Point(154, 100);
            btn6.Name = "btn6";
            btn6.Size = new Size(46, 50);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Khaki;
            btn5.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn5.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn5.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn5.Location = new Point(92, 100);
            btn5.Name = "btn5";
            btn5.Size = new Size(46, 50);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Khaki;
            btn8.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn8.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn8.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn8.Location = new Point(92, 44);
            btn8.Name = "btn8";
            btn8.Size = new Size(46, 50);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.Khaki;
            btnDecimal.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnDecimal.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnDecimal.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btnDecimal.Location = new Point(92, 212);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(46, 50);
            btnDecimal.TabIndex = 1;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Khaki;
            btn9.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn9.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn9.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn9.Location = new Point(154, 44);
            btn9.Name = "btn9";
            btn9.Size = new Size(46, 50);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Khaki;
            btn4.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn4.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn4.Location = new Point(30, 100);
            btn4.Name = "btn4";
            btn4.Size = new Size(46, 50);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(flowLayoutPanel1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(359, 46);
            panel5.Name = "panel5";
            panel5.Size = new Size(416, 328);
            panel5.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 3, 3, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(416, 328);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // frmCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 511);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmCashier";
            Text = "frmCashier";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private Panel panel1;
        private Panel panel3;
        private Button btnClear;
        private Button btn7;
        private Button btn2;
        private Button btn3;
        private Button btn1;
        private Button btn0;
        private Button btn6;
        private Button btn5;
        private Button btn8;
        private Button btnDecimal;
        private Button btn9;
        private Button btn4;
        private Panel panel5;
        private DataGridView dataGridViewCart;
        private Panel panel6;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPay;
        private Panel panel7;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button btnClearCart;
        private Button button15;
        private Label lbCustomerChanged;
        private Label lbCutomerMoney;
        private Button btnEnter;
        private Button btnBack;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewImageColumn colIncrease;
        private DataGridViewImageColumn colDecrease;
        private CuoreUI.Controls.cuiTextBox txtAmount;
        private CuoreUI.Controls.cuiComboBox comboPayment;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiTextBox txtSubTotal;
        private CuoreUI.Controls.cuiLabel lbCashierName;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
    }
}