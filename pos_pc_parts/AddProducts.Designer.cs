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
            panel2 = new Panel();
            comboCategories = new ComboBox();
            txtImagePath = new Label();
            btnClear = new Button();
            Price = new Label();
            btnSave = new Button();
            label4 = new Label();
            btnUpdate = new Button();
            btnBrowse = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colImagePath = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
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
            // panel2
            // 
            panel2.Controls.Add(comboCategories);
            panel2.Controls.Add(txtImagePath);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(Price);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnBrowse);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(txtQuantity);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 175);
            panel2.TabIndex = 6;
            // 
            // comboCategories
            // 
            comboCategories.FormattingEnabled = true;
            comboCategories.Location = new Point(90, 40);
            comboCategories.Name = "comboCategories";
            comboCategories.Size = new Size(197, 23);
            comboCategories.TabIndex = 2;
            // 
            // txtImagePath
            // 
            txtImagePath.AutoSize = true;
            txtImagePath.Location = new Point(541, 7);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(38, 15);
            txtImagePath.TabIndex = 5;
            txtImagePath.Text = "label3";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(357, 137);
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
            Price.Location = new Point(29, 101);
            Price.Name = "Price";
            Price.Size = new Size(53, 15);
            Price.TabIndex = 1;
            Price.Text = "Quantity";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(177, 137);
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
            label4.Location = new Point(29, 73);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 1;
            label4.Text = "Price";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(267, 137);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 26);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(510, 144);
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
            label2.Location = new Point(29, 44);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(470, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 113);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 14);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(90, 69);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(197, 23);
            txtPrice.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(90, 11);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(197, 23);
            txtProductName.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(90, 98);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(197, 23);
            txtQuantity.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colImagePath, colName, colCategory, colPrice, colQuantity, colEdit, colDelete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(684, 275);
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
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(684, 275);
            panel3.TabIndex = 7;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private ComboBox comboCategories;
        private Label label4;
        private Label Price;
        private Label label2;
        private Label label1;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtProductName;
        private PictureBox pictureBox1;
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
    }
}