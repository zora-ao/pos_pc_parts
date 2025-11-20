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
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            btnCategory = new Button();
            button1 = new Button();
            admin_main_panel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 45);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.EZPC;
            pictureBox2.Location = new Point(37, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnCategory);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 505);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 102);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 2;
            label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 222);
            button3.Name = "button3";
            button3.Size = new Size(121, 38);
            button3.TabIndex = 0;
            button3.Text = "Add Products";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(21, 440);
            button4.Name = "button4";
            button4.Size = new Size(102, 38);
            button4.TabIndex = 0;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(12, 279);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(121, 38);
            btnCategory.TabIndex = 0;
            btnCategory.Text = "Manage Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 165);
            button1.Name = "button1";
            button1.Size = new Size(121, 38);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // admin_main_panel
            // 
            admin_main_panel.Dock = DockStyle.Fill;
            admin_main_panel.Location = new Point(148, 45);
            admin_main_panel.Name = "admin_main_panel";
            admin_main_panel.Size = new Size(752, 505);
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private Label label1;
        private Panel admin_main_panel;
    }
}
