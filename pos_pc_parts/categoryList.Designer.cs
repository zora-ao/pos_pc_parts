namespace pos_pc_parts
{
    partial class categoryList
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
            label2 = new Label();
            txtAddCat = new TextBox();
            btnSaveCat = new Button();
            btnUpdateCat = new Button();
            btnCancelCat = new Button();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnCancelCat);
            panel1.Controls.Add(txtAddCat);
            panel1.Controls.Add(btnUpdateCat);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSaveCat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 86);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // txtAddCat
            // 
            txtAddCat.Location = new Point(73, 42);
            txtAddCat.Name = "txtAddCat";
            txtAddCat.Size = new Size(255, 23);
            txtAddCat.TabIndex = 2;
            // 
            // btnSaveCat
            // 
            btnSaveCat.Location = new Point(334, 42);
            btnSaveCat.Name = "btnSaveCat";
            btnSaveCat.Size = new Size(75, 23);
            btnSaveCat.TabIndex = 3;
            btnSaveCat.Text = "Save";
            btnSaveCat.UseVisualStyleBackColor = true;
            btnSaveCat.Click += btnSaveCat_Click;
            // 
            // btnUpdateCat
            // 
            btnUpdateCat.Location = new Point(415, 41);
            btnUpdateCat.Name = "btnUpdateCat";
            btnUpdateCat.Size = new Size(75, 23);
            btnUpdateCat.TabIndex = 3;
            btnUpdateCat.Text = "Update";
            btnUpdateCat.UseVisualStyleBackColor = true;
            // 
            // btnCancelCat
            // 
            btnCancelCat.Location = new Point(495, 41);
            btnCancelCat.Name = "btnCancelCat";
            btnCancelCat.Size = new Size(75, 23);
            btnCancelCat.TabIndex = 3;
            btnCancelCat.Text = "Clear";
            btnCancelCat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Add Category";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 188);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colCategory, colEdit, colDelete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(608, 188);
            dataGridView1.TabIndex = 5;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
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
            // categoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 274);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "categoryList";
            Text = "categoryList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtAddCat;
        private Button btnSaveCat;
        private Button btnUpdateCat;
        private Button btnCancelCat;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
    }
}