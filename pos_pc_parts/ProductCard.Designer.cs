namespace pos_pc_parts
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            lblName = new CuoreUI.Controls.cuiLabel();
            lblPrice = new CuoreUI.Controls.cuiLabel();
            lblQty = new CuoreUI.Controls.cuiLabel();
            pictureBox1 = new PictureBox();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(pictureBox1);
            cuiPanel1.Location = new Point(3, 3);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(144, 72);
            cuiPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Content = "Ryzen\\ 7";
            lblName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblName.HorizontalAlignment = StringAlignment.Center;
            lblName.Location = new Point(4, 81);
            lblName.Margin = new Padding(4, 3, 4, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 19);
            lblName.TabIndex = 1;
            lblName.VerticalAlignment = StringAlignment.Near;
            // 
            // lblPrice
            // 
            lblPrice.Content = "P3500";
            lblPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPrice.ForeColor = SystemColors.ActiveCaption;
            lblPrice.HorizontalAlignment = StringAlignment.Center;
            lblPrice.Location = new Point(3, 103);
            lblPrice.Margin = new Padding(4, 3, 4, 3);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(57, 19);
            lblPrice.TabIndex = 1;
            lblPrice.VerticalAlignment = StringAlignment.Near;
            // 
            // lblQty
            // 
            lblQty.Content = "Qty\\.\\ 10";
            lblQty.HorizontalAlignment = StringAlignment.Center;
            lblQty.Location = new Point(4, 125);
            lblQty.Margin = new Padding(4, 3, 4, 3);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(53, 19);
            lblQty.TabIndex = 2;
            lblQty.VerticalAlignment = StringAlignment.Near;
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = Properties.Resources.CX550_550_Watt_80_Plus_Bronze_Php_3095;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblQty);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(cuiPanel1);
            Name = "ProductCard";
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel lblName;
        private CuoreUI.Controls.cuiLabel lblPrice;
        private CuoreUI.Controls.cuiLabel lblQty;
        private PictureBox pictureBox1;
    }
}
