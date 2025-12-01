namespace pos_pc_parts
{
    partial class frmCreateAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAcc));
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            button2 = new Button();
            txtRePass = new CuoreUI.Controls.cuiTextBox();
            txtPassword = new CuoreUI.Controls.cuiTextBox();
            txtUsername = new CuoreUI.Controls.cuiTextBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiComboBox1 = new CuoreUI.Controls.cuiComboBox();
            btnCreateAcc = new CuoreUI.Controls.cuiButton();
            Show_Password = new Guna.UI2.WinForms.Guna2CheckBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackgroundImage = Properties.Resources.bg_login;
            cuiPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            cuiPanel1.Dock = DockStyle.Fill;
            cuiPanel1.ForeColor = Color.CornflowerBlue;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.Transparent;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(0, 8, 8, 0);
            cuiPanel1.Size = new Size(364, 509);
            cuiPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cuiPanel2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(364, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 509);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(button2);
            cuiPanel2.Controls.Add(txtRePass);
            cuiPanel2.Controls.Add(txtPassword);
            cuiPanel2.Controls.Add(txtUsername);
            cuiPanel2.Controls.Add(cuiLabel1);
            cuiPanel2.Controls.Add(cuiComboBox1);
            cuiPanel2.Controls.Add(btnCreateAcc);
            cuiPanel2.Controls.Add(Show_Password);
            cuiPanel2.Location = new Point(50, 153);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(346, 337);
            cuiPanel2.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(207, 301);
            button2.Name = "button2";
            button2.Size = new Size(68, 23);
            button2.TabIndex = 19;
            button2.Text = "Signin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtRePass
            // 
            txtRePass.BackColor = Color.Transparent;
            txtRePass.BackgroundColor = Color.WhiteSmoke;
            txtRePass.Content = "";
            txtRePass.FocusBackgroundColor = Color.White;
            txtRePass.FocusImageTint = Color.White;
            txtRePass.FocusOutlineColor = Color.Silver;
            txtRePass.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRePass.ForeColor = Color.Black;
            txtRePass.Image = null;
            txtRePass.ImageExpand = new Point(0, 0);
            txtRePass.ImageOffset = new Point(0, 0);
            txtRePass.Location = new Point(26, 130);
            txtRePass.Margin = new Padding(4);
            txtRePass.Multiline = false;
            txtRePass.Name = "txtRePass";
            txtRePass.NormalImageTint = Color.White;
            txtRePass.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtRePass.Padding = new Padding(16, 14, 16, 0);
            txtRePass.PasswordChar = true;
            txtRePass.PlaceholderColor = Color.Black;
            txtRePass.PlaceholderText = "Re-enter password";
            txtRePass.Rounding = new Padding(8);
            txtRePass.Size = new Size(289, 45);
            txtRePass.TabIndex = 17;
            txtRePass.TextOffset = new Size(0, 0);
            txtRePass.UnderlinedStyle = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BackgroundColor = Color.WhiteSmoke;
            txtPassword.Content = "";
            txtPassword.FocusBackgroundColor = Color.White;
            txtPassword.FocusImageTint = Color.White;
            txtPassword.FocusOutlineColor = Color.Silver;
            txtPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Image = null;
            txtPassword.ImageExpand = new Point(0, 0);
            txtPassword.ImageOffset = new Point(0, 0);
            txtPassword.Location = new Point(26, 77);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtPassword.Padding = new Padding(16, 14, 16, 0);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.Black;
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Rounding = new Padding(8);
            txtPassword.Size = new Size(289, 45);
            txtPassword.TabIndex = 17;
            txtPassword.TextOffset = new Size(0, 0);
            txtPassword.UnderlinedStyle = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BackgroundColor = Color.WhiteSmoke;
            txtUsername.Content = "";
            txtUsername.FocusBackgroundColor = Color.White;
            txtUsername.FocusImageTint = Color.White;
            txtUsername.FocusOutlineColor = Color.Silver;
            txtUsername.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Image = null;
            txtUsername.ImageExpand = new Point(0, 0);
            txtUsername.ImageOffset = new Point(0, 0);
            txtUsername.Location = new Point(26, 19);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.NormalImageTint = Color.White;
            txtUsername.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtUsername.Padding = new Padding(16, 14, 16, 0);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.Black;
            txtUsername.PlaceholderText = "Enter username";
            txtUsername.Rounding = new Padding(8);
            txtUsername.Size = new Size(289, 45);
            txtUsername.TabIndex = 18;
            txtUsername.TextOffset = new Size(0, 0);
            txtUsername.UnderlinedStyle = true;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Already\\ Have\\ an\\ account\\?";
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(57, 306);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(155, 18);
            cuiLabel1.TabIndex = 16;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiComboBox1
            // 
            cuiComboBox1.BackColor = Color.Transparent;
            cuiComboBox1.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuiComboBox1.DropDownBackgroundColor = Color.White;
            cuiComboBox1.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cuiComboBox1.ExpandArrowColor = Color.Gray;
            cuiComboBox1.ForeColor = Color.Black;
            cuiComboBox1.Items = new string[]
    {
    "Admin",
    "Cashier"
    };
            cuiComboBox1.Location = new Point(26, 191);
            cuiComboBox1.Margin = new Padding(4, 3, 4, 3);
            cuiComboBox1.Name = "cuiComboBox1";
            cuiComboBox1.NoSelectionText = "None";
            cuiComboBox1.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiComboBox1.OutlineThickness = 1F;
            cuiComboBox1.Rounding = 8;
            cuiComboBox1.SelectedIndex = 0;
            cuiComboBox1.SelectedItem = "Admin";
            cuiComboBox1.Size = new Size(134, 38);
            cuiComboBox1.SortAlphabetically = true;
            cuiComboBox1.TabIndex = 15;
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.CheckButton = false;
            btnCreateAcc.Checked = false;
            btnCreateAcc.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCreateAcc.CheckedForeColor = Color.White;
            btnCreateAcc.CheckedImageTint = Color.White;
            btnCreateAcc.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCreateAcc.Content = "Create Account";
            btnCreateAcc.DialogResult = DialogResult.None;
            btnCreateAcc.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAcc.ForeColor = Color.White;
            btnCreateAcc.HoverBackground = Color.White;
            btnCreateAcc.HoverForeColor = Color.Black;
            btnCreateAcc.HoverImageTint = Color.White;
            btnCreateAcc.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCreateAcc.Image = null;
            btnCreateAcc.ImageAutoCenter = true;
            btnCreateAcc.ImageExpand = new Point(0, 0);
            btnCreateAcc.ImageOffset = new Point(0, 0);
            btnCreateAcc.Location = new Point(94, 249);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.NormalBackground = Color.FromArgb(27, 60, 83);
            btnCreateAcc.NormalForeColor = Color.White;
            btnCreateAcc.NormalImageTint = Color.White;
            btnCreateAcc.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnCreateAcc.OutlineThickness = 1F;
            btnCreateAcc.PressedBackground = Color.WhiteSmoke;
            btnCreateAcc.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCreateAcc.PressedImageTint = Color.White;
            btnCreateAcc.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCreateAcc.Rounding = new Padding(8);
            btnCreateAcc.Size = new Size(153, 45);
            btnCreateAcc.TabIndex = 14;
            btnCreateAcc.TextAlignment = StringAlignment.Center;
            btnCreateAcc.TextOffset = new Point(0, 0);
            btnCreateAcc.Click += btnCreateAcc_Click;
            // 
            // Show_Password
            // 
            Show_Password.AutoSize = true;
            Show_Password.BackColor = Color.Transparent;
            Show_Password.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Show_Password.CheckedState.BorderRadius = 0;
            Show_Password.CheckedState.BorderThickness = 0;
            Show_Password.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Show_Password.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Show_Password.ForeColor = Color.Black;
            Show_Password.Location = new Point(186, 210);
            Show_Password.Name = "Show_Password";
            Show_Password.Size = new Size(119, 19);
            Show_Password.TabIndex = 8;
            Show_Password.Text = "Show Password";
            Show_Password.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Show_Password.UncheckedState.BorderRadius = 0;
            Show_Password.UncheckedState.BorderThickness = 0;
            Show_Password.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            Show_Password.UseVisualStyleBackColor = false;
            Show_Password.CheckedChanged += Show_Password_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(391, 3);
            button1.Name = "button1";
            button1.Size = new Size(45, 25);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmCreateAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(cuiPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCreateAcc";
            Text = "frmCreateAcc";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiComboBox cuiComboBox1;
        private CuoreUI.Controls.cuiButton btnCreateAcc;
        private Guna.UI2.WinForms.Guna2CheckBox Show_Password;
        private Button button1;
        private CuoreUI.Controls.cuiTextBox txtRePass;
        private CuoreUI.Controls.cuiTextBox txtPassword;
        private CuoreUI.Controls.cuiTextBox txtUsername;
        private Button button2;
    }
}