namespace pos_pc_parts
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            btnCategory = new Button();
            button1 = new Button();
            admin_main_panel = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 44);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 104, 130);
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnCategory);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 506);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(46, 396);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "POS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 102);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 2;
            label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.package;
            button3.Location = new Point(26, 208);
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
            button4.Location = new Point(26, 451);
            button4.Name = "button4";
            button4.Size = new Size(125, 43);
            button4.TabIndex = 0;
            button4.Text = "Logout";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.Image = Properties.Resources.list;
            btnCategory.Location = new Point(26, 277);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(135, 59);
            btnCategory.TabIndex = 0;
            btnCategory.Text = "Manage Category";
            btnCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.clipboard;
            button1.Location = new Point(26, 139);
            button1.Name = "button1";
            button1.Size = new Size(135, 59);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // admin_main_panel
            // 
            admin_main_panel.Dock = DockStyle.Fill;
            admin_main_panel.Location = new Point(185, 44);
            admin_main_panel.Name = "admin_main_panel";
            admin_main_panel.Size = new Size(715, 506);
            admin_main_panel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(admin_main_panel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
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
        private Button button2;
    }
}
