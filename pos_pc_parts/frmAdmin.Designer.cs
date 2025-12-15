namespace pos_pc_parts
{
    partial class frmAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            btnAddUsers = new Button();
            btnSales = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            btnCategory = new Button();
            admin_main_panel = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(69, 104, 130);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 38);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 104, 130);
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnAddUsers);
            panel2.Controls.Add(btnSales);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnCategory);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 537);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Image = Properties.Resources.clipboard;
            button1.Location = new Point(26, 123);
            button1.Name = "button1";
            button1.Size = new Size(135, 59);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddUsers
            // 
            btnAddUsers.Image = Properties.Resources.si_user_fill;
            btnAddUsers.Location = new Point(26, 386);
            btnAddUsers.Name = "btnAddUsers";
            btnAddUsers.Size = new Size(135, 59);
            btnAddUsers.TabIndex = 0;
            btnAddUsers.Text = "Add Users";
            btnAddUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddUsers.UseVisualStyleBackColor = true;
            btnAddUsers.Click += btnAddUsers_Click;
            // 
            // btnSales
            // 
            btnSales.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSales.Image = (Image)resources.GetObject("btnSales.Image");
            btnSales.ImageAlign = ContentAlignment.MiddleRight;
            btnSales.Location = new Point(26, 320);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(135, 59);
            btnSales.TabIndex = 0;
            btnSales.Text = "Sales";
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell Nova", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 2;
            label1.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.package;
            button3.Location = new Point(26, 188);
            button3.Name = "button3";
            button3.Size = new Size(135, 59);
            button3.TabIndex = 0;
            button3.Text = "Add Products";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.log_out;
            button4.Location = new Point(40, 482);
            button4.Name = "button4";
            button4.Size = new Size(106, 43);
            button4.TabIndex = 0;
            button4.Text = "Logout";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnCategory
            // 
            btnCategory.Image = Properties.Resources.list;
            btnCategory.Location = new Point(26, 254);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(135, 59);
            btnCategory.TabIndex = 0;
            btnCategory.Text = "Manage Category";
            btnCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // admin_main_panel
            // 
            admin_main_panel.Dock = DockStyle.Fill;
            admin_main_panel.Location = new Point(185, 38);
            admin_main_panel.Name = "admin_main_panel";
            admin_main_panel.Size = new Size(752, 537);
            admin_main_panel.TabIndex = 2;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 575);
            Controls.Add(admin_main_panel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmAdmin";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Button btnCategory;
        private Button button1;
        private Label label1;
        private Panel admin_main_panel;
        private Button btnSales;
        private Button btnAddUsers;
    }
}
