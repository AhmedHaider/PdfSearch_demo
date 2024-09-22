using System.Windows.Forms;

namespace PdfSearch_demo;

public partial class frmAdmin : Form
{
    public frmAdmin()
    {
        InitializeComponent();
    }

    private void frmAdmin_Load(object sender, EventArgs e)
    {
        using (var db = new AppDbContext())
        {
            var data = db.Users.ToList();

            dgvMain.DataSource = data;
        }

        int editableColumnIndex = 3;

        foreach (DataGridViewRow row in dgvMain.Rows)
            row.Cells[editableColumnIndex].ReadOnly = false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (dgvMain.Rows.Count < 1)
            return;

        using var db = new AppDbContext();
        for (int i = 0; i < dgvMain.Rows.Count; i++)
        {
            var user = db.Users.SingleOrDefault(u => u.Id == (int)dgvMain.Rows[i].Cells[0].Value);
            if (user != null)
                user.IsAuthorized = (bool)dgvMain.Rows[i].Cells[3].Value;
        }
        db.SaveChanges();
    }
}
