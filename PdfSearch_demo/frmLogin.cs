using Microsoft.Data.Sqlite;
using SQLitePCL;
using System.DirectoryServices.AccountManagement;
using System.Runtime.InteropServices;

namespace PdfSearch_demo;

public partial class frmLogin : Form
{

    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

    public frmLogin()
    {
        InitializeComponent();
    }

    private bool ValidateCredentials(string username, string password)
    {
        using var db = new AppDbContext();
        var user = db.Users.Where(u => u.Username.ToLower() == username.Trim().ToLower() && u.Password == password && u.IsAuthorized).FirstOrDefault();
        return user != null;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUserName.Text;
        string password = txtPassword.Text;

        if (ValidateCredentials(username, password))
        {
            DialogResult = DialogResult.OK;
        }
        else
        {
            MessageBox.Show("Invalid username or password. Please try again.", "INVALID CREDENTIALS!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();

    private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

    private void label4_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }

    private void lblCreateAccount_Click(object sender, EventArgs e)
    {
        frmCreateAccount frm = new();
        frm.ShowDialog();
    }

    private void btnDomainLogin_Click(object sender, EventArgs e)
    {
        string domain = Environment.UserDomainName;
        string username = Environment.UserName;

        // Check if the current user is part of the domain
        if (IsUserPartOfDomain(domain, username))
        {
            SaveUserToDatabase(username);
            DialogResult = DialogResult.OK;
        }
        else
            MessageBox.Show($"User [{username}] is not part of the domain [{domain}] or not authorized.");
    }

    // Check if the current user is part of a domain
    private bool IsUserPartOfDomain(string domain, string username)
    {
        try
        {
            using (PrincipalContext context = new(ContextType.Domain, domain))
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(context, username);
                return user != null; // If the user is found in the domain, return true
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error checking domain membership: {ex.Message}");
            return false; // If there's an issue (e.g., machine is not part of a domain), return false
        }
    }

    private void frmLogin_Load(object sender, EventArgs e)
    {
        txtDomainName.Text = Environment.UserDomainName;
        txtDomainUserName.Text = Environment.UserName;
    }

    // Save user details to SQLite database
    void SaveUserToDatabase(string domainUserName)
    {
        using var db = new AppDbContext();
        var userExists = db.Users.FirstOrDefault(u => u.Username == txtDomainUserName.Text);

        if (userExists == null)
        {
            var user = new User
            {
                Username = domainUserName,
                IsAuthorized = true
            };
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}