namespace pos_pc_parts
{
    partial class AddProducts
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
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colImagePath = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            panel2 = new Panel();
            pictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            comboCategories = new CuoreUI.Controls.cuiComboBox();
            txtQuantity = new CuoreUI.Controls.cuiTextBox();
            txtPrice = new CuoreUI.Controls.cuiTextBox();
            txtProductName = new CuoreUI.Controls.cuiTextBox();
            txtImagePath = new Label();
            btnClear = new Button();
            Price = new Label();
            btnSave = new Button();
            label4 = new Label();
            btnUpdate = new Button();
            btnBrowse = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(684, 223);
            panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colImagePath, colName, colCategory, colPrice, colQuantity, colEdit, colDelete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.Size = new Size(684, 223);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colImagePath
            // 
            colImagePath.HeaderText = "image_path";
            colImagePath.Name = "colImagePath";
            colImagePath.ReadOnly = true;
            colImagePath.Visible = false;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colEdit.HeaderText = "Edit";
            colEdit.Image = Properties.Resources.edit;
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Width = 33;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colDelete.HeaderText = "Delete";
            colDelete.Image = Properties.Resources.trash_2;
            colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Width = 46;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(comboCategories);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(txtImagePath);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(Price);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnBrowse);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 227);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Content = null;
            pictureBox1.ImageTint = Color.White;
            pictureBox1.Location = new Point(436, 16);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.OutlineThickness = 1F;
            pictureBox1.PanelOutlineColor = Color.Empty;
            pictureBox1.Rotation = 0;
            pictureBox1.Rounding = new Padding(8);
            pictureBox1.Size = new Size(214, 145);
            pictureBox1.TabIndex = 6;
            // 
            // comboCategories
            // 
            comboCategories.BackgroundColor = Color.FromArgb(255, 255, 255);
            comboCategories.DropDownBackgroundColor = Color.White;
            comboCategories.DropDownForeColor = Color.FromArgb(27, 27, 27);
            comboCategories.ExpandArrowColor = Color.Gray;
            comboCategories.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboCategories.ForeColor = Color.Black;
            comboCategories.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            comboCategories.Location = new Point(97, 59);
            comboCategories.Margin = new Padding(5, 4, 5, 4);
            comboCategories.Name = "comboCategories";
            comboCategories.NoSelectionText = "None";
            comboCategories.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            comboCategories.OutlineThickness = 1F;
            comboCategories.RightToLeft = RightToLeft.No;
            comboCategories.Rounding = 8;
            comboCategories.SelectedIndex = -1;
            comboCategories.SelectedItem = "";
            comboCategories.Size = new Size(132, 31);
            comboCategories.SortAlphabetically = true;
            comboCategories.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.BackgroundColor = Color.White;
            txtQuantity.Content = "";
            txtQuantity.FocusBackgroundColor = Color.White;
            txtQuantity.FocusImageTint = Color.White;
            txtQuantity.FocusOutlineColor = Color.Silver;
            txtQuantity.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            txtQuantity.ForeColor = Color.Black;
            txtQuantity.Image = null;
            txtQuantity.ImageExpand = new Point(0, 0);
            txtQuantity.ImageOffset = new Point(0, 0);
            txtQuantity.Location = new Point(96, 139);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Multiline = false;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.NormalImageTint = Color.White;
            txtQuantity.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtQuantity.Padding = new Padding(19, 7, 19, 0);
            txtQuantity.PasswordChar = false;
            txtQuantity.PlaceholderColor = Color.LightGray;
            txtQuantity.PlaceholderText = "Placeholder text..";
            txtQuantity.Rounding = new Padding(8);
            txtQuantity.Size = new Size(197, 33);
            txtQuantity.TabIndex = 4;
            txtQuantity.TextOffset = new Size(0, 0);
            txtQuantity.UnderlinedStyle = true;
            // 
            // txtPrice
            // 
            txtPrice.BackgroundColor = Color.White;
            txtPrice.Content = "";
            txtPrice.FocusBackgroundColor = Color.White;
            txtPrice.FocusImageTint = Color.White;
            txtPrice.FocusOutlineColor = Color.Silver;
            txtPrice.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            txtPrice.ForeColor = Color.Black;
            txtPrice.Image = null;
            txtPrice.ImageExpand = new Point(0, 0);
            txtPrice.ImageOffset = new Point(0, 0);
            txtPrice.Location = new Point(96, 98);
            txtPrice.Margin = new Padding(4);
            txtPrice.Multiline = false;
            txtPrice.Name = "txtPrice";
            txtPrice.NormalImageTint = Color.White;
            txtPrice.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtPrice.Padding = new Padding(19, 7, 19, 0);
            txtPrice.PasswordChar = false;
            txtPrice.PlaceholderColor = Color.LightGray;
            txtPrice.PlaceholderText = "Placeholder text..";
            txtPrice.Rounding = new Padding(8);
            txtPrice.Size = new Size(197, 33);
            txtPrice.TabIndex = 3;
            txtPrice.TextOffset = new Size(0, 0);
            txtPrice.UnderlinedStyle = true;
            // 
            // txtProductName
            // 
            txtProductName.BackgroundColor = Color.White;
            txtProductName.Content = "";
            txtProductName.FocusBackgroundColor = Color.White;
            txtProductName.FocusImageTint = Color.White;
            txtProductName.FocusOutlineColor = Color.Silver;
            txtProductName.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            txtProductName.ForeColor = Color.Black;
            txtProductName.Image = null;
            txtProductName.ImageExpand = new Point(0, 0);
            txtProductName.ImageOffset = new Point(0, 0);
            txtProductName.Location = new Point(96, 18);
            txtProductName.Margin = new Padding(4);
            txtProductName.Multiline = false;
            txtProductName.Name = "txtProductName";
            txtProductName.NormalImageTint = Color.White;
            txtProductName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtProductName.Padding = new Padding(19, 7, 19, 0);
            txtProductName.PasswordChar = false;
            txtProductName.PlaceholderColor = Color.LightGray;
            txtProductName.PlaceholderText = "Product Name";
            txtProductName.Rounding = new Padding(8);
            txtProductName.Size = new Size(197, 33);
            txtProductName.TabIndex = 1;
            txtProductName.TextOffset = new Size(0, 0);
            txtProductName.UnderlinedStyle = true;
            // 
            // txtImagePath
            // 
            txtImagePath.AutoSize = true;
            txtImagePath.Location = new Point(506, 16);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(0, 15);
            txtImagePath.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(585, 189);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 26);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            Price.Location = new Point(21, 151);
            Price.Name = "Price";
            Price.Size = new Size(73, 21);
            Price.TabIndex = 1;
            Price.Text = "Quantity";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(405, 189);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 26);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label4.Location = new Point(41, 110);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 1;
            label4.Text = "Price";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(495, 189);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 26);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(130, 179);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(99, 26);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Browse Image";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label2.Location = new Point(25, 69);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold);
            label1.Location = new Point(41, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProducts";
            Text = "AddProducts";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label4;
        private Label Price;
        private Label label2;
        private Label label1;
        private Button btnBrowse;
        private Button btnClear;
        private Button btnSave;
        private Button btnUpdate;
        private Label txtImagePath;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colImagePath;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
        private Panel panel2;
        private Panel panel3;
        private CuoreUI.Controls.cuiTextBox txtProductName;
        private CuoreUI.Controls.cuiComboBox comboCategories;
        private CuoreUI.Controls.cuiTextBox txtPrice;
        private CuoreUI.Controls.cuiTextBox txtQuantity;
        private CuoreUI.Controls.cuiPictureBox pictureBox1;
    }
}