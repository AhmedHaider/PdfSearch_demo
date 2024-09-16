using PdfSearch_demol;
using System.Diagnostics;

namespace PdfSearch_demo;

public partial class frmMain : Form
{
    string executingDirectory = string.Empty;

    public frmMain()
    {
        InitializeComponent();
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
        using FolderBrowserDialog fbd = new FolderBrowserDialog();
        if (fbd.ShowDialog() == DialogResult.OK)
            txtFolderPath.Text = fbd.SelectedPath;
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        // Validate the inputs
        if (string.IsNullOrWhiteSpace(txtFolderPath.Text))
        {
            MessageBox.Show("Select a base directory...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFolderPath.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtSearchTerm.Text))
        {
            MessageBox.Show("Type a search term...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSearchTerm.Focus();
            return;
        }

        executingDirectory = txtFolderPath.Text;

        // Clear the previous results
        lstResult.Items.Clear();

        pbSpinner.Visible = true;

        // Execute the search asynchronously
        await Task.Run(() =>
        {
            if (rdoFileName.Checked)
            {
                SearchService.SearchFileName(lstResult, txtFolderPath, txtSearchTerm);
            }
            else
            {
                SearchService.SearchFileContent(lstResult, txtFolderPath, txtSearchTerm);
            }
        });
        pbSpinner.Visible = false;
        lblResultCount.Text = $"No. of Files Found: {lstResult.Items.Count}";

        // Show a message if no files are found
        if (lstResult.Items.Count < 1)
        {
            MessageBox.Show("No files found containing your search criterion.");
        }
    }

    private void lstResult_DoubleClick(object sender, EventArgs e)
    {
        if (lstResult.SelectedItem != null)
        {
            // Combine the current directory with the selected file name to get the full path
            string fileName = lstResult.SelectedItem.ToString();
            string filePath = Path.Combine(executingDirectory, fileName);

            // Check if the file exists before trying to open it
            if (File.Exists(filePath))
            {
                // Use Process.Start to open the file using the default PDF viewer
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                // Show an error message if the file is not found
                MessageBox.Show("File not found: " + filePath);
            }
        }
    }
}

