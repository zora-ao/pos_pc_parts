namespace pos_pc_parts
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            comboRole = new CuoreUI.Controls.cuiComboBox();
            btnLogin = new CuoreUI.Controls.cuiButton();
            txtPassword = new CuoreUI.Controls.cuiTextBox();
            Show_Password = new Guna.UI2.WinForms.Guna2CheckBox();
            txtUsername = new CuoreUI.Controls.cuiTextBox();
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
            cuiPanel1.Size = new Size(463, 520);
            cuiPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cuiPanel2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(463, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 520);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(comboRole);
            cuiPanel2.Controls.Add(btnLogin);
            cuiPanel2.Controls.Add(txtPassword);
            cuiPanel2.Controls.Add(Show_Password);
            cuiPanel2.Controls.Add(txtUsername);
            cuiPanel2.Location = new Point(50, 153);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(346, 318);
            cuiPanel2.TabIndex = 13;
            // 
            // comboRole
            // 
            comboRole.BackColor = Color.Transparent;
            comboRole.BackgroundColor = Color.FromArgb(255, 255, 255);
            comboRole.DropDownBackgroundColor = Color.White;
            comboRole.DropDownForeColor = Color.FromArgb(27, 27, 27);
            comboRole.ExpandArrowColor = Color.Gray;
            comboRole.ForeColor = Color.Black;
            comboRole.Items = new string[]
    {
    "Admin",
    "Cashier"
    };
            comboRole.Location = new Point(26, 148);
            comboRole.Margin = new Padding(4, 3, 4, 3);
            comboRole.Name = "comboRole";
            comboRole.NoSelectionText = "None";
            comboRole.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            comboRole.OutlineThickness = 1F;
            comboRole.Rounding = 8;
            comboRole.SelectedIndex = 0;
            comboRole.SelectedItem = "Admin";
            comboRole.Size = new Size(134, 38);
            comboRole.SortAlphabetically = true;
            comboRole.TabIndex = 15;
            // 
            // btnLogin
            // 
            btnLogin.CheckButton = false;
            btnLogin.Checked = false;
            btnLogin.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnLogin.CheckedForeColor = Color.White;
            btnLogin.CheckedImageTint = Color.White;
            btnLogin.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnLogin.Content = "Login";
            btnLogin.DialogResult = DialogResult.None;
            btnLogin.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverBackground = Color.White;
            btnLogin.HoverForeColor = Color.Black;
            btnLogin.HoverImageTint = Color.White;
            btnLogin.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnLogin.Image = null;
            btnLogin.ImageAutoCenter = true;
            btnLogin.ImageExpand = new Point(0, 0);
            btnLogin.ImageOffset = new Point(0, 0);
            btnLogin.Location = new Point(97, 235);
            btnLogin.Name = "btnLogin";
            btnLogin.NormalBackground = Color.FromArgb(27, 60, 83);
            btnLogin.NormalForeColor = Color.White;
            btnLogin.NormalImageTint = Color.White;
            btnLogin.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogin.OutlineThickness = 1F;
            btnLogin.PressedBackground = Color.WhiteSmoke;
            btnLogin.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnLogin.PressedImageTint = Color.White;
            btnLogin.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogin.Rounding = new Padding(8);
            btnLogin.Size = new Size(153, 45);
            btnLogin.TabIndex = 14;
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.TextOffset = new Point(0, 0);
            btnLogin.Click += btnLogin_Click;
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
            txtPassword.Location = new Point(26, 82);
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
            txtPassword.TabIndex = 0;
            txtPassword.TextOffset = new Size(0, 0);
            txtPassword.UnderlinedStyle = true;
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
            Show_Password.Location = new Point(196, 167);
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
            txtUsername.Location = new Point(26, 24);
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
            txtUsername.TabIndex = 0;
            txtUsername.TextOffset = new Size(0, 0);
            txtUsername.UnderlinedStyle = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(390, -1);
            button1.Name = "button1";
            button1.Size = new Size(45, 25);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(899, 520);
            Controls.Add(cuiPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
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
        private CuoreUI.Controls.cuiComboBox comboRole;
        private CuoreUI.Controls.cuiButton btnLogin;
        private CuoreUI.Controls.cuiTextBox cuiTextBox3;
        private CuoreUI.Controls.cuiTextBox txtPassword;
        private Guna.UI2.WinForms.Guna2CheckBox Show_Password;
        private CuoreUI.Controls.cuiTextBox txtUsername;
        private Button button1;
    }
}