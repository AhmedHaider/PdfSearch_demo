namespace PdfSearch_demo
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblTitle = new Label();
            btnClose = new Button();
            lblTitleBar = new Label();
            btnMinimize = new Button();
            grpLogin = new GroupBox();
            lblCreateAccount = new Label();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(8, 34);
            txtUserName.MaxLength = 20;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username";
            txtUserName.Size = new Size(205, 23);
            txtUserName.TabIndex = 0;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(8, 63);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(205, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(57, 62, 70);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(8, 112);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(205, 33);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BorderStyle = BorderStyle.FixedSingle;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gray;
            lblTitle.Location = new Point(6, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(72, 17);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "PDF Search";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Tomato;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(228, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 27);
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitleBar
            // 
            lblTitleBar.BackColor = Color.FromArgb(57, 62, 70);
            lblTitleBar.BorderStyle = BorderStyle.Fixed3D;
            lblTitleBar.Dock = DockStyle.Top;
            lblTitleBar.Location = new Point(0, 0);
            lblTitleBar.Name = "lblTitleBar";
            lblTitleBar.Size = new Size(264, 28);
            lblTitleBar.TabIndex = 2;
            lblTitleBar.MouseDown += label4_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(57, 62, 70);
            btnMinimize.FlatAppearance.BorderColor = Color.White;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(191, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(36, 27);
            btnMinimize.TabIndex = 3;
            btnMinimize.TabStop = false;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(txtUserName);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grpLogin.ForeColor = Color.WhiteSmoke;
            grpLogin.Location = new Point(22, 46);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(221, 162);
            grpLogin.TabIndex = 4;
            grpLogin.TabStop = false;
            grpLogin.Text = "Login:";
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.BorderStyle = BorderStyle.FixedSingle;
            lblCreateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCreateAccount.Location = new Point(80, 268);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(105, 17);
            lblCreateAccount.TabIndex = 5;
            lblCreateAccount.Text = "Create an account";
            lblCreateAccount.Click += lblCreateAccount_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(264, 292);
            Controls.Add(lblCreateAccount);
            Controls.Add(grpLogin);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(lblTitleBar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblTitle;
        private Button btnClose;
        private Label lblTitleBar;
        private Button btnMinimize;
        private GroupBox grpLogin;
        private Label lblCreateAccount;
    }
}