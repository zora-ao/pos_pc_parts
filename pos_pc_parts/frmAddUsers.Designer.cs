namespace pos_pc_parts
{
    partial class frmAddUsers
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
            dataGridView1 = new DataGridView();
            colUserName = new DataGridViewTextBoxColumn();
            colUserRole = new DataGridViewTextBoxColumn();
            colRemoveUser = new DataGridViewImageColumn();
            txtUserName = new CuoreUI.Controls.cuiTextBox();
            txtUserPassword = new CuoreUI.Controls.cuiTextBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            btnClearUser = new Button();
            btnSaveUser = new Button();
            comboUserRole = new CuoreUI.Controls.cuiComboBox();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colUserName, colUserRole, colRemoveUser });
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(438, 366);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colUserName
            // 
            colUserName.HeaderText = "Name";
            colUserName.Name = "colUserName";
            colUserName.ReadOnly = true;
            // 
            // colUserRole
            // 
            colUserRole.HeaderText = "Role";
            colUserRole.Name = "colUserRole";
            colUserRole.ReadOnly = true;
            // 
            // colRemoveUser
            // 
            colRemoveUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colRemoveUser.HeaderText = "";
            colRemoveUser.Image = Properties.Resources.trash_2;
            colRemoveUser.Name = "colRemoveUser";
            colRemoveUser.ReadOnly = true;
            colRemoveUser.Width = 5;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.BackgroundColor = Color.White;
            txtUserName.Content = "";
            txtUserName.FocusBackgroundColor = Color.White;
            txtUserName.FocusImageTint = Color.White;
            txtUserName.FocusOutlineColor = Color.Silver;
            txtUserName.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Image = null;
            txtUserName.ImageExpand = new Point(0, 0);
            txtUserName.ImageOffset = new Point(0, 0);
            txtUserName.Location = new Point(495, 86);
            txtUserName.Margin = new Padding(4);
            txtUserName.Multiline = false;
            txtUserName.Name = "txtUserName";
            txtUserName.NormalImageTint = Color.White;
            txtUserName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtUserName.Padding = new Padding(17, 14, 17, 0);
            txtUserName.PasswordChar = false;
            txtUserName.PlaceholderColor = Color.LightGray;
            txtUserName.PlaceholderText = "Placeholder text..";
            txtUserName.Rounding = new Padding(8);
            txtUserName.Size = new Size(236, 45);
            txtUserName.TabIndex = 1;
            txtUserName.TextOffset = new Size(0, 0);
            txtUserName.UnderlinedStyle = true;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserPassword.BackgroundColor = Color.White;
            txtUserPassword.Content = "";
            txtUserPassword.FocusBackgroundColor = Color.White;
            txtUserPassword.FocusImageTint = Color.White;
            txtUserPassword.FocusOutlineColor = Color.Silver;
            txtUserPassword.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserPassword.ForeColor = Color.Black;
            txtUserPassword.Image = null;
            txtUserPassword.ImageExpand = new Point(0, 0);
            txtUserPassword.ImageOffset = new Point(0, 0);
            txtUserPassword.Location = new Point(495, 168);
            txtUserPassword.Margin = new Padding(4);
            txtUserPassword.Multiline = false;
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.NormalImageTint = Color.White;
            txtUserPassword.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtUserPassword.Padding = new Padding(17, 14, 17, 0);
            txtUserPassword.PasswordChar = false;
            txtUserPassword.PlaceholderColor = Color.LightGray;
            txtUserPassword.PlaceholderText = "Placeholder text..";
            txtUserPassword.Rounding = new Padding(8);
            txtUserPassword.Size = new Size(236, 45);
            txtUserPassword.TabIndex = 1;
            txtUserPassword.TextOffset = new Size(0, 0);
            txtUserPassword.UnderlinedStyle = true;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiLabel1.Content = "Name";
            cuiLabel1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(486, 56);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(245, 23);
            cuiLabel1.TabIndex = 2;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiLabel2.Content = "Password";
            cuiLabel2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(477, 138);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(245, 23);
            cuiLabel2.TabIndex = 2;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // btnClearUser
            // 
            btnClearUser.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnClearUser.Location = new Point(511, 343);
            btnClearUser.Name = "btnClearUser";
            btnClearUser.Size = new Size(76, 31);
            btnClearUser.TabIndex = 3;
            btnClearUser.Text = "Clear";
            btnClearUser.UseVisualStyleBackColor = true;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            btnSaveUser.Location = new Point(620, 343);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(76, 31);
            btnSaveUser.TabIndex = 3;
            btnSaveUser.Text = "Save";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // comboUserRole
            // 
            comboUserRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboUserRole.BackgroundColor = Color.FromArgb(255, 255, 255);
            comboUserRole.DropDownBackgroundColor = Color.White;
            comboUserRole.DropDownForeColor = Color.FromArgb(27, 27, 27);
            comboUserRole.ExpandArrowColor = Color.Gray;
            comboUserRole.ForeColor = Color.Black;
            comboUserRole.Items = new string[]
    {
    "Cashier",
    "Admin"
    };
            comboUserRole.Location = new Point(513, 249);
            comboUserRole.Margin = new Padding(4, 3, 4, 3);
            comboUserRole.Name = "comboUserRole";
            comboUserRole.NoSelectionText = "None";
            comboUserRole.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            comboUserRole.OutlineThickness = 1F;
            comboUserRole.Rounding = 8;
            comboUserRole.SelectedIndex = 0;
            comboUserRole.SelectedItem = "Cashier";
            comboUserRole.Size = new Size(197, 52);
            comboUserRole.SortAlphabetically = true;
            comboUserRole.TabIndex = 4;
            // 
            // cuiLabel3
            // 
            cuiLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiLabel3.Content = "Role";
            cuiLabel3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(477, 220);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(245, 23);
            cuiLabel3.TabIndex = 2;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // frmAddUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboUserRole);
            Controls.Add(btnSaveUser);
            Controls.Add(btnClearUser);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserName);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddUsers";
            Text = "frmAddUsers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private CuoreUI.Controls.cuiTextBox txtUserName;
        private CuoreUI.Controls.cuiTextBox txtUserPassword;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private Button btnClearUser;
        private Button btnSaveUser;
        private CuoreUI.Controls.cuiComboBox comboUserRole;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private DataGridViewTextBoxColumn colUserName;
        private DataGridViewTextBoxColumn colUserRole;
        private DataGridViewImageColumn colRemoveUser;
    }
}