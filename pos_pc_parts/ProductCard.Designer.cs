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
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            pictureBox1 = new PictureBox();
            lblQty = new CuoreUI.Controls.cuiLabel();
            lblPrice = new CuoreUI.Controls.cuiLabel();
            lblName = new CuoreUI.Controls.cuiLabel();
            cuiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(pictureBox1);
            cuiPanel2.Controls.Add(lblQty);
            cuiPanel2.Controls.Add(lblPrice);
            cuiPanel2.Controls.Add(lblName);
            cuiPanel2.Dock = DockStyle.Fill;
            cuiPanel2.Location = new Point(0, 0);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(150, 150);
            cuiPanel2.TabIndex = 1;
            cuiPanel2.Paint += cuiPanel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.InitialImage = Properties.Resources.CX550_550_Watt_80_Plus_Bronze_Php_3095;
            pictureBox1.Location = new Point(6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(0, 5, 0, 5);
            pictureBox1.Size = new Size(138, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblQty
            // 
            lblQty.Content = "Qty\\.\\ 10";
            lblQty.HorizontalAlignment = StringAlignment.Center;
            lblQty.Location = new Point(7, 127);
            lblQty.Margin = new Padding(4, 3, 4, 3);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(53, 19);
            lblQty.TabIndex = 6;
            lblQty.VerticalAlignment = StringAlignment.Near;
            // 
            // lblPrice
            // 
            lblPrice.Content = "P3500";
            lblPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblPrice.ForeColor = SystemColors.ActiveCaption;
            lblPrice.HorizontalAlignment = StringAlignment.Center;
            lblPrice.Location = new Point(6, 105);
            lblPrice.Margin = new Padding(4, 3, 4, 3);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(57, 19);
            lblPrice.TabIndex = 4;
            lblPrice.VerticalAlignment = StringAlignment.Near;
            // 
            // lblName
            // 
            lblName.Content = "Ryzen\\ 7";
            lblName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblName.HorizontalAlignment = StringAlignment.Center;
            lblName.Location = new Point(7, 83);
            lblName.Margin = new Padding(4, 3, 4, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 19);
            lblName.TabIndex = 5;
            lblName.VerticalAlignment = StringAlignment.Near;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cuiPanel2);
            Name = "ProductCard";
            cuiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiLabel lblQty;
        private CuoreUI.Controls.cuiLabel lblPrice;
        private CuoreUI.Controls.cuiLabel lblName;
    }
}
