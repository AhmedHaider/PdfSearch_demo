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
        var user = db.Users.Where(u => u.Username.ToLower() == username.Trim().ToLower() && u.Password == password).FirstOrDefault();
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
        var frm = new frmCreateAccount();
        frm.ShowDialog();
    }
}
