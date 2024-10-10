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
        using FolderBrowserDialog fbd = BrowseFolder();
    }

    private FolderBrowserDialog BrowseFolder()
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        if (fbd.ShowDialog() == DialogResult.OK)
            txtFolderPath.Text = fbd.SelectedPath;
        return fbd;
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
                SearchService.SearchFileName(lstResult, txtFolderPath, txtSearchTerm);
            else
                SearchService.SearchFileContent(lstResult, txtFolderPath, txtSearchTerm);
        });

        pbSpinner.Visible = false;
        lblResultCount.Text = $"No. of Files Found: {lstResult.Items.Count}";

        // Show a message if no files are found
        if (lstResult.Items.Count < 1)
            MessageBox.Show("No files found containing your search criterion.");
    }

    private void lstResult_DoubleClick(object sender, EventArgs e)
    {
        OpenFile();
    }

    private void OpenFile()
    {
        if (lstResult.SelectedItem != null)
        {
            // Combine the current directory with the selected file name to get the full path
            string? fileName = lstResult.SelectedItem as string;


            if (fileName != null)
            {
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

    private void ctxItemOpen_Click(object sender, EventArgs e)
    {
        OpenFile();
    }

    private void lstResult_MouseDown(object sender, MouseEventArgs e)
    {
        var cuurentList = (ListBox)sender;
        var index = cuurentList.IndexFromPoint(e.Location);

        if (e.Button == MouseButtons.Right)
            if (index != -1)
                cuurentList.SelectedIndex = index;
    }

    private void ctxItemSaveTo_Click(object sender, EventArgs e)
    {
        if (lstResult.SelectedIndex != -1)
        {
            string sourceFilePath = Path.Combine(executingDirectory, lstResult.SelectedItem!.ToString()!);
            SaveFileDialog saveFileDialog = new()
            {
                FileName = Path.GetFileName(sourceFilePath), // Set initial filename based on source
                Filter = "PDF Files (*.pdf)|*.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = saveFileDialog.FileName;
                try
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    MessageBox.Show("File saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }
    }

    //private void ctxItemSaveTo_Click(object sender, EventArgs e)
    //{
    //    if (lstResult.SelectedIndex != -1)
    //    {
    //        string listBoxItem = lstResult.SelectedItem!.ToString()!;
    //        int indexOfPage = listBoxItem.IndexOf(" - Page "); // Find the separator

    //        if (indexOfPage != -1)
    //        {
    //            string actualFileName = listBoxItem.Substring(0, indexOfPage); // Extract filename
    //            string sourceFilePath = Path.Combine(executingDirectory, actualFileName); // Append extension

    //            SaveFileDialog saveFileDialog = new()
    //            {
    //                FileName = Path.GetFileName(sourceFilePath), // Set initial filename based on source
    //                Filter = "PDF Files (*.pdf)|*.pdf"
    //            };

    //            if (saveFileDialog.ShowDialog() == DialogResult.OK)
    //            {
    //                string destinationFilePath = saveFileDialog.FileName;
    //                try
    //                {
    //                    File.Copy(sourceFilePath, destinationFilePath, true);
    //                    MessageBox.Show("File saved successfully.");
    //                }
    //                catch (Exception ex)
    //                {
    //                    MessageBox.Show("Error saving file: " + ex.Message);
    //                }
    //            }
    //        }
    //        else
    //        {
    //            // Handle case where page number is missing
    //            MessageBox.Show("Selected item doesn't contain page number information.");
    //        }
    //    }
    //}

    private void txtFolderPath_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.O)
            btnBrowse_Click(sender, e);
    }

    private void miAdmin_Click(object sender, EventArgs e)
    {
        frmAdmin frm = new();
        frm.ShowDialog();
    }
}

