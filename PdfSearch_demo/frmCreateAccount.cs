namespace PdfSearch_demo
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Close();
                return;
            }

            using var db = new AppDbContext();
            var newUser = new User
            {
                Username = txtUserName.Text,
                Password = txtPassword.Text,
                IsAuthorized = true
            };

            db.Users.Add(newUser);
            db.SaveChanges();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
