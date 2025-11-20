namespace pos_pc_parts
{
    partial class dashboardContents
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
            panel3 = new Panel();
            panel4 = new Panel();
            lbTotalItems = new Label();
            label5 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 154);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(lbTotalItems);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(77, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 0;
            // 
            // lbTotalItems
            // 
            lbTotalItems.AutoSize = true;
            lbTotalItems.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalItems.Location = new Point(73, 44);
            lbTotalItems.Name = "lbTotalItems";
            lbTotalItems.Size = new Size(37, 29);
            lbTotalItems.TabIndex = 0;
            lbTotalItems.Text = "25";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 17);
            label5.Name = "label5";
            label5.Size = new Size(153, 15);
            label5.TabIndex = 0;
            label5.Text = "Total Number of Products:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.CornflowerBlue;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(424, 33);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 44);
            label3.Name = "label3";
            label3.Size = new Size(61, 29);
            label3.TabIndex = 0;
            label3.Text = "5000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 17);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 0;
            label2.Text = "Total Sales:";
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colPrice, colQuantity, colEdit, colDelete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(700, 296);
            dataGridView1.TabIndex = 4;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
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
            // dashboardContents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboardContents";
            Text = "dashboardContents";
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel4;
        private Label lbTotalItems;
        private Label label5;
        private Panel panel5;
        private Label label3;
        private Label label2;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
    }
}