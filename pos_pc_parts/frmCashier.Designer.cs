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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            lbCashierName = new CuoreUI.Controls.cuiLabel();
            button17 = new Button();
            btnClearCart = new Button();
            btnPay = new Button();
            comboPayment = new CuoreUI.Controls.cuiComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridViewCart = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colIncrease = new DataGridViewImageColumn();
            colDecrease = new DataGridViewImageColumn();
            panel3 = new Panel();
            txtAmount = new CuoreUI.Controls.cuiTextBox();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            btn3 = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btnBack = new Button();
            btn5 = new Button();
            btnDecimal = new Button();
            btn8 = new Button();
            panel1 = new Panel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            pictureBox2 = new PictureBox();
            lbTotal = new CuoreUI.Controls.cuiLabel();
            lbTax = new CuoreUI.Controls.cuiLabel();
            lbSubTotal = new CuoreUI.Controls.cuiLabel();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            panel5.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(cuiLabel2);
            panel2.Controls.Add(lbCashierName);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1134, 46);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.streamline_freehand_shop_cashier;
            pictureBox1.Location = new Point(23, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Cashier:";
            cuiLabel2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            cuiLabel2.ForeColor = Color.Black;
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(61, 6);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(70, 17);
            cuiLabel2.TabIndex = 1;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // lbCashierName
            // 
            lbCashierName.Content = "Jose";
            lbCashierName.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            lbCashierName.ForeColor = Color.Black;
            lbCashierName.HorizontalAlignment = StringAlignment.Near;
            lbCashierName.Location = new Point(70, 23);
            lbCashierName.Margin = new Padding(4, 3, 4, 3);
            lbCashierName.Name = "lbCashierName";
            lbCashierName.Size = new Size(97, 23);
            lbCashierName.TabIndex = 1;
            lbCashierName.VerticalAlignment = StringAlignment.Near;
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
            button17.ImageAlign = ContentAlignment.BottomCenter;
            button17.Location = new Point(126, 445);
            button17.Name = "button17";
            button17.Size = new Size(80, 30);
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
            btnClearCart.FlatStyle = FlatStyle.Popup;
            btnClearCart.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCart.ImageAlign = ContentAlignment.BottomCenter;
            btnClearCart.Location = new Point(41, 444);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(80, 30);
            btnClearCart.TabIndex = 4;
            btnClearCart.Text = "Clear";
            btnClearCart.TextAlign = ContentAlignment.BottomCenter;
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPay.BackColor = Color.FromArgb(155, 180, 192);
            btnPay.FlatAppearance.CheckedBackColor = Color.Silver;
            btnPay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPay.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnPay.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(32, 304);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(197, 52);
            btnPay.TabIndex = 4;
            btnPay.Text = "Pay";
            btnPay.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
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
            comboPayment.Location = new Point(126, 383);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label5.Location = new Point(41, 386);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 1;
            label5.Text = "Payment: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label4.Location = new Point(35, 435);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 1;
            label4.Text = "Tax: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label3.Location = new Point(35, 408);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 1;
            label3.Text = "Sub Total:";
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.AllowUserToAddRows = false;
            dataGridViewCart.AllowUserToDeleteRows = false;
            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCart.BackgroundColor = Color.White;
            dataGridViewCart.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colQuantity, colPrice, colIncrease, colDecrease });
            dataGridViewCart.Dock = DockStyle.Top;
            dataGridViewCart.GridColor = Color.IndianRed;
            dataGridViewCart.Location = new Point(0, 0);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.ReadOnly = true;
            dataGridViewCart.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewCart.Size = new Size(346, 393);
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
            dataGridViewCellStyle1.BackColor = Color.Lime;
            colName.DefaultCellStyle = dataGridViewCellStyle1;
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
            panel3.Location = new Point(775, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 200);
            panel3.TabIndex = 3;
            // 
            // txtAmount
            // 
            txtAmount.BackgroundColor = Color.LightGray;
            txtAmount.Content = "";
            txtAmount.FocusBackgroundColor = Color.White;
            txtAmount.FocusImageTint = Color.White;
            txtAmount.FocusOutlineColor = Color.DarkKhaki;
            txtAmount.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.ForeColor = Color.White;
            txtAmount.Image = null;
            txtAmount.ImageExpand = new Point(0, 0);
            txtAmount.ImageOffset = new Point(0, 0);
            txtAmount.Location = new Point(15, 30);
            txtAmount.Margin = new Padding(4);
            txtAmount.Multiline = false;
            txtAmount.Name = "txtAmount";
            txtAmount.NormalImageTint = Color.White;
            txtAmount.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtAmount.Padding = new Padding(21, 11, 21, 0);
            txtAmount.PasswordChar = false;
            txtAmount.PlaceholderColor = Color.White;
            txtAmount.PlaceholderText = "Enter here";
            txtAmount.Rounding = new Padding(8);
            txtAmount.Size = new Size(247, 43);
            txtAmount.TabIndex = 1;
            txtAmount.TextOffset = new Size(0, 0);
            txtAmount.UnderlinedStyle = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(flowLayoutPanel1);
            panel5.Controls.Add(cuiPanel1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(369, 46);
            panel5.Name = "panel5";
            panel5.Size = new Size(765, 556);
            panel5.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(6, 7);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(475, 537);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cuiPanel1.Controls.Add(pictureBox3);
            cuiPanel1.Controls.Add(label6);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(txtAmount);
            cuiPanel1.Controls.Add(btn3);
            cuiPanel1.Controls.Add(btnClearCart);
            cuiPanel1.Controls.Add(btn0);
            cuiPanel1.Controls.Add(btnPay);
            cuiPanel1.Controls.Add(btn1);
            cuiPanel1.Controls.Add(btn4);
            cuiPanel1.Controls.Add(btn2);
            cuiPanel1.Controls.Add(comboPayment);
            cuiPanel1.Controls.Add(button17);
            cuiPanel1.Controls.Add(btn6);
            cuiPanel1.Controls.Add(btn9);
            cuiPanel1.Controls.Add(btn7);
            cuiPanel1.Controls.Add(btnBack);
            cuiPanel1.Controls.Add(btn5);
            cuiPanel1.Controls.Add(btnDecimal);
            cuiPanel1.Controls.Add(label5);
            cuiPanel1.Controls.Add(btn8);
            cuiPanel1.Location = new Point(487, 6);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(266, 537);
            cuiPanel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.log_out1;
            pictureBox3.Location = new Point(220, 510);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(218, 491);
            label6.Name = "label6";
            label6.Size = new Size(44, 16);
            label6.TabIndex = 7;
            label6.Text = "Logout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label2.Location = new Point(15, 5);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 5;
            label2.Text = "Amount";
            // 
            // btn3
            // 
            btn3.BackColor = Color.Transparent;
            btn3.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn3.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn3.Location = new Point(170, 192);
            btn3.Name = "btn3";
            btn3.Size = new Size(57, 50);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Transparent;
            btn0.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn0.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn0.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn0.Location = new Point(32, 248);
            btn0.Name = "btn0";
            btn0.Size = new Size(57, 50);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Transparent;
            btn1.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn1.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn1.Location = new Point(32, 192);
            btn1.Name = "btn1";
            btn1.Size = new Size(57, 50);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Transparent;
            btn4.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn4.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn4.Location = new Point(32, 136);
            btn4.Name = "btn4";
            btn4.Size = new Size(57, 50);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Transparent;
            btn2.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn2.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn2.Location = new Point(101, 192);
            btn2.Name = "btn2";
            btn2.Size = new Size(57, 50);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Transparent;
            btn6.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn6.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn6.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn6.Location = new Point(170, 136);
            btn6.Name = "btn6";
            btn6.Size = new Size(57, 50);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Transparent;
            btn9.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn9.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn9.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn9.Location = new Point(170, 80);
            btn9.Name = "btn9";
            btn9.Size = new Size(57, 50);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Transparent;
            btn7.FlatAppearance.BorderColor = Color.Red;
            btn7.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btn7.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn7.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn7.Location = new Point(32, 80);
            btn7.Name = "btn7";
            btn7.Size = new Size(57, 50);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnBack.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnBack.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btnBack.Location = new Point(170, 248);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(57, 50);
            btnBack.TabIndex = 1;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Transparent;
            btn5.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn5.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn5.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn5.Location = new Point(101, 136);
            btn5.Name = "btn5";
            btn5.Size = new Size(57, 50);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.Transparent;
            btnDecimal.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnDecimal.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnDecimal.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btnDecimal.Location = new Point(101, 248);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(57, 50);
            btnDecimal.TabIndex = 1;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Transparent;
            btn8.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn8.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btn8.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            btn8.Location = new Point(101, 80);
            btn8.Name = "btn8";
            btn8.Size = new Size(57, 50);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(cuiPanel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 556);
            panel1.TabIndex = 2;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(pictureBox2);
            cuiPanel2.Controls.Add(lbTotal);
            cuiPanel2.Controls.Add(lbTax);
            cuiPanel2.Controls.Add(lbSubTotal);
            cuiPanel2.Controls.Add(dataGridViewCart);
            cuiPanel2.Controls.Add(label1);
            cuiPanel2.Controls.Add(label3);
            cuiPanel2.Controls.Add(label4);
            cuiPanel2.Location = new Point(12, 7);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(346, 537);
            cuiPanel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Line_8;
            pictureBox2.Location = new Point(23, 469);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(292, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lbTotal
            // 
            lbTotal.Content = "0\\.00";
            lbTotal.HorizontalAlignment = StringAlignment.Center;
            lbTotal.Location = new Point(130, 493);
            lbTotal.Margin = new Padding(4, 3, 4, 3);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(167, 29);
            lbTotal.TabIndex = 2;
            lbTotal.VerticalAlignment = StringAlignment.Near;
            // 
            // lbTax
            // 
            lbTax.Content = "0\\.00";
            lbTax.HorizontalAlignment = StringAlignment.Center;
            lbTax.Location = new Point(130, 435);
            lbTax.Margin = new Padding(4, 3, 4, 3);
            lbTax.Name = "lbTax";
            lbTax.Size = new Size(167, 29);
            lbTax.TabIndex = 2;
            lbTax.VerticalAlignment = StringAlignment.Near;
            // 
            // lbSubTotal
            // 
            lbSubTotal.Content = "0\\.00";
            lbSubTotal.HorizontalAlignment = StringAlignment.Center;
            lbSubTotal.Location = new Point(130, 408);
            lbSubTotal.Margin = new Padding(4, 3, 4, 3);
            lbSubTotal.Name = "lbSubTotal";
            lbSubTotal.Size = new Size(167, 21);
            lbSubTotal.TabIndex = 2;
            lbSubTotal.VerticalAlignment = StringAlignment.Near;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label1.Location = new Point(35, 492);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 1;
            label1.Text = "Total:";
            // 
            // frmCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 602);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCashier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCashier";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            panel5.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private DataGridView dataGridViewCart;
        private Label label4;
        private Label label3;
        private Button btnPay;
        private Label label5;
        private Button button18;
        private Button button17;
        private Button btnClearCart;
        private Button button15;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewImageColumn colIncrease;
        private DataGridViewImageColumn colDecrease;
        private CuoreUI.Controls.cuiTextBox txtAmount;
        private CuoreUI.Controls.cuiComboBox comboPayment;
        private CuoreUI.Controls.cuiLabel lbCashierName;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Panel panel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CuoreUI.Controls.cuiLabel lbSubTotal;
        private CuoreUI.Controls.cuiLabel lbTotal;
        private CuoreUI.Controls.cuiLabel lbTax;
        private Button btn3;
        private Button btn0;
        private Button btn1;
        private Button btn4;
        private Button btn2;
        private Button btn6;
        private Button btn9;
        private Button btn7;
        private Button btnBack;
        private Button btn5;
        private Button btnDecimal;
        private Button btn8;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label6;
        private PictureBox pictureBox3;
    }
}