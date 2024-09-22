namespace PdfSearch_demo
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnSearch = new Button();
            txtFolderPath = new TextBox();
            btnBrowse = new Button();
            txtSearchTerm = new TextBox();
            lstResult = new ListBox();
            ctxHelperMenu = new ContextMenuStrip(components);
            ctxItemOpen = new ToolStripMenuItem();
            ctxItemSaveTo = new ToolStripMenuItem();
            rdoFileName = new RadioButton();
            rdoContent = new RadioButton();
            lblSearchDirectory = new Label();
            lblResults = new Label();
            pbSpinner = new PictureBox();
            lblResultCount = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            miAdmin = new ToolStripMenuItem();
            ctxHelperMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpinner).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(500, 104);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(41, 23);
            btnSearch.TabIndex = 5;
            toolTip1.SetToolTip(btnSearch, "ENTER");
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFolderPath.BackColor = Color.FromArgb(57, 62, 70);
            txtFolderPath.ForeColor = Color.White;
            txtFolderPath.Location = new Point(12, 44);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.ReadOnly = true;
            txtFolderPath.Size = new Size(482, 23);
            txtFolderPath.TabIndex = 0;
            txtFolderPath.KeyDown += txtFolderPath_KeyDown;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Location = new Point(500, 44);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(41, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "...";
            toolTip1.SetToolTip(btnBrowse, "CTRL+O");
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchTerm.BackColor = Color.FromArgb(57, 62, 70);
            txtSearchTerm.ForeColor = Color.White;
            txtSearchTerm.Location = new Point(12, 104);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(482, 23);
            txtSearchTerm.TabIndex = 4;
            // 
            // lstResult
            // 
            lstResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstResult.BackColor = Color.FromArgb(57, 62, 70);
            lstResult.ContextMenuStrip = ctxHelperMenu;
            lstResult.ForeColor = Color.White;
            lstResult.FormattingEnabled = true;
            lstResult.ItemHeight = 15;
            lstResult.Location = new Point(12, 160);
            lstResult.Name = "lstResult";
            lstResult.ScrollAlwaysVisible = true;
            lstResult.Size = new Size(482, 169);
            lstResult.TabIndex = 6;
            lstResult.DoubleClick += lstResult_DoubleClick;
            lstResult.MouseDown += lstResult_MouseDown;
            // 
            // ctxHelperMenu
            // 
            ctxHelperMenu.Items.AddRange(new ToolStripItem[] { ctxItemOpen, ctxItemSaveTo });
            ctxHelperMenu.Name = "ctxHelperMenu";
            ctxHelperMenu.Size = new Size(114, 48);
            // 
            // ctxItemOpen
            // 
            ctxItemOpen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctxItemOpen.Image = Properties.Resources.pdf_48px;
            ctxItemOpen.Name = "ctxItemOpen";
            ctxItemOpen.Size = new Size(113, 22);
            ctxItemOpen.Text = "Open";
            ctxItemOpen.Click += ctxItemOpen_Click;
            // 
            // ctxItemSaveTo
            // 
            ctxItemSaveTo.Image = Properties.Resources.save_as_480px;
            ctxItemSaveTo.Name = "ctxItemSaveTo";
            ctxItemSaveTo.Size = new Size(113, 22);
            ctxItemSaveTo.Text = "Save To";
            ctxItemSaveTo.Click += ctxItemSaveTo_Click;
            // 
            // rdoFileName
            // 
            rdoFileName.AutoSize = true;
            rdoFileName.Checked = true;
            rdoFileName.Location = new Point(12, 79);
            rdoFileName.Name = "rdoFileName";
            rdoFileName.Size = new Size(78, 19);
            rdoFileName.TabIndex = 2;
            rdoFileName.TabStop = true;
            rdoFileName.Text = "File Name";
            rdoFileName.UseVisualStyleBackColor = true;
            // 
            // rdoContent
            // 
            rdoContent.AutoSize = true;
            rdoContent.Location = new Point(112, 79);
            rdoContent.Name = "rdoContent";
            rdoContent.Size = new Size(68, 19);
            rdoContent.TabIndex = 3;
            rdoContent.Text = "Content";
            rdoContent.UseVisualStyleBackColor = true;
            // 
            // lblSearchDirectory
            // 
            lblSearchDirectory.AutoSize = true;
            lblSearchDirectory.Location = new Point(8, 27);
            lblSearchDirectory.Name = "lblSearchDirectory";
            lblSearchDirectory.Size = new Size(96, 15);
            lblSearchDirectory.TabIndex = 4;
            lblSearchDirectory.Text = "Search Directory:";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(12, 142);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(47, 15);
            lblResults.TabIndex = 4;
            lblResults.Text = "Results:";
            // 
            // pbSpinner
            // 
            pbSpinner.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbSpinner.Image = Properties.Resources.adobe_spinner;
            pbSpinner.Location = new Point(500, 160);
            pbSpinner.Name = "pbSpinner";
            pbSpinner.Size = new Size(35, 31);
            pbSpinner.SizeMode = PictureBoxSizeMode.Zoom;
            pbSpinner.TabIndex = 7;
            pbSpinner.TabStop = false;
            pbSpinner.Visible = false;
            // 
            // lblResultCount
            // 
            lblResultCount.BorderStyle = BorderStyle.FixedSingle;
            lblResultCount.Dock = DockStyle.Bottom;
            lblResultCount.Location = new Point(0, 331);
            lblResultCount.Name = "lblResultCount";
            lblResultCount.Size = new Size(549, 23);
            lblResultCount.TabIndex = 8;
            lblResultCount.Text = "No. of Files Found:";
            lblResultCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(57, 62, 70);
            menuStrip1.Items.AddRange(new ToolStripItem[] { miAdmin });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(549, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // miAdmin
            // 
            miAdmin.ForeColor = Color.WhiteSmoke;
            miAdmin.Name = "miAdmin";
            miAdmin.Size = new Size(55, 20);
            miAdmin.Text = "Admin";
            miAdmin.Click += miAdmin_Click;
            // 
            // frmMain
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(549, 354);
            Controls.Add(menuStrip1);
            Controls.Add(lblResultCount);
            Controls.Add(pbSpinner);
            Controls.Add(lblResults);
            Controls.Add(lblSearchDirectory);
            Controls.Add(rdoContent);
            Controls.Add(rdoFileName);
            Controls.Add(lstResult);
            Controls.Add(txtSearchTerm);
            Controls.Add(txtFolderPath);
            Controls.Add(btnBrowse);
            Controls.Add(btnSearch);
            ForeColor = Color.White;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(565, 393);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDF Search";
            ctxHelperMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSpinner).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtFolderPath;
        private Button btnBrowse;
        private TextBox txtSearchTerm;
        private ListBox lstResult;
        private RadioButton rdoFileName;
        private RadioButton rdoContent;
        private Label lblSearchDirectory;
        private Label lblResults;
        private PictureBox pbSpinner;
        private Label lblResultCount;
        private ContextMenuStrip ctxHelperMenu;
        private ToolStripMenuItem ctxItemOpen;
        private ToolStripMenuItem ctxItemSaveTo;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem miAdmin;
    }
}
