namespace PdfSearch_demo
{
    partial class frmTestEncrypt
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
            btnEncrypt = new Button();
            textBox1 = new TextBox();
            btnBrowse = new Button();
            btnDecrypt = new Button();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(320, 98);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(124, 23);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(741, 23);
            textBox1.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(687, 41);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(320, 140);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(124, 23);
            btnDecrypt.TabIndex = 0;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // frmTestEncrypt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrowse);
            Controls.Add(textBox1);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Name = "frmTestEncrypt";
            Text = "frmTestEncrypt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncrypt;
        private TextBox textBox1;
        private Button btnBrowse;
        private Button btnDecrypt;
    }
}