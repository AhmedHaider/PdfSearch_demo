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
            btnLocalLogin = new Button();
            lblTitle = new Label();
            btnClose = new Button();
            lblTitleBar = new Label();
            btnMinimize = new Button();
            grpLogin = new GroupBox();
            lblCreateAccount = new Label();
            grpDomainLogin = new GroupBox();
            txtDomainName = new TextBox();
            txtDomainUserName = new TextBox();
            btnDomainLogin = new Button();
            grpLogin.SuspendLayout();
            grpDomainLogin.SuspendLayout();
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
            txtUserName.Text = "admin";
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
            txtPassword.Text = "123";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLocalLogin
            // 
            btnLocalLogin.BackColor = Color.FromArgb(57, 62, 70);
            btnLocalLogin.FlatStyle = FlatStyle.Flat;
            btnLocalLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLocalLogin.ForeColor = Color.White;
            btnLocalLogin.Location = new Point(8, 112);
            btnLocalLogin.Name = "btnLocalLogin";
            btnLocalLogin.Size = new Size(205, 33);
            btnLocalLogin.TabIndex = 2;
            btnLocalLogin.Text = "Local Login";
            btnLocalLogin.UseVisualStyleBackColor = false;
            btnLocalLogin.Click += btnLogin_Click;
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
            btnClose.Location = new Point(459, 0);
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
            lblTitleBar.Size = new Size(497, 28);
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
            btnMinimize.Location = new Point(422, 0);
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
            grpLogin.Controls.Add(btnLocalLogin);
            grpLogin.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grpLogin.ForeColor = Color.WhiteSmoke;
            grpLogin.Location = new Point(12, 46);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(221, 162);
            grpLogin.TabIndex = 4;
            grpLogin.TabStop = false;
            grpLogin.Text = "Local:";
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.BorderStyle = BorderStyle.FixedSingle;
            lblCreateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCreateAccount.Location = new Point(64, 211);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(105, 17);
            lblCreateAccount.TabIndex = 5;
            lblCreateAccount.Text = "Create an account";
            lblCreateAccount.Click += lblCreateAccount_Click;
            // 
            // grpDomainLogin
            // 
            grpDomainLogin.Controls.Add(txtDomainName);
            grpDomainLogin.Controls.Add(txtDomainUserName);
            grpDomainLogin.Controls.Add(btnDomainLogin);
            grpDomainLogin.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grpDomainLogin.ForeColor = Color.WhiteSmoke;
            grpDomainLogin.Location = new Point(263, 46);
            grpDomainLogin.Name = "grpDomainLogin";
            grpDomainLogin.Size = new Size(221, 162);
            grpDomainLogin.TabIndex = 4;
            grpDomainLogin.TabStop = false;
            grpDomainLogin.Text = "Domain:";
            // 
            // txtDomainName
            // 
            txtDomainName.Location = new Point(8, 34);
            txtDomainName.MaxLength = 20;
            txtDomainName.Name = "txtDomainName";
            txtDomainName.PlaceholderText = "Domain";
            txtDomainName.Size = new Size(205, 23);
            txtDomainName.TabIndex = 0;
            txtDomainName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDomainUserName
            // 
            txtDomainUserName.Location = new Point(8, 63);
            txtDomainUserName.MaxLength = 20;
            txtDomainUserName.Name = "txtDomainUserName";
            txtDomainUserName.PlaceholderText = "Domain User Name";
            txtDomainUserName.Size = new Size(205, 23);
            txtDomainUserName.TabIndex = 1;
            txtDomainUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDomainLogin
            // 
            btnDomainLogin.BackColor = Color.FromArgb(57, 62, 70);
            btnDomainLogin.FlatStyle = FlatStyle.Flat;
            btnDomainLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDomainLogin.ForeColor = Color.White;
            btnDomainLogin.Location = new Point(8, 112);
            btnDomainLogin.Name = "btnDomainLogin";
            btnDomainLogin.Size = new Size(205, 33);
            btnDomainLogin.TabIndex = 2;
            btnDomainLogin.Text = "Domain Login";
            btnDomainLogin.UseVisualStyleBackColor = false;
            btnDomainLogin.Click += btnDomainLogin_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLocalLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(497, 242);
            Controls.Add(lblCreateAccount);
            Controls.Add(grpDomainLogin);
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
            Load += frmLogin_Load;
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            grpDomainLogin.ResumeLayout(false);
            grpDomainLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLocalLogin;
        private Label lblTitle;
        private Button btnClose;
        private Label lblTitleBar;
        private Button btnMinimize;
        private GroupBox grpLogin;
        private Label lblCreateAccount;
        private GroupBox grpDomainLogin;
        private TextBox txtDomainName;
        private TextBox txtDomainUserName;
        private Button btnDomainLogin;
    }
}