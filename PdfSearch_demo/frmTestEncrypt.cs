namespace PdfSearch_demo;

public partial class frmTestEncrypt : Form
{
    private DatabaseEncryptor encryptor;

    public frmTestEncrypt()
    {
        InitializeComponent();

        // Create a DatabaseEncryptor instance with a suitable password
        encryptor = new DatabaseEncryptor("IiV80SDjpayTkm27sR09nLn5szjxyXj9dRxHMW3pIzX5b6xc");
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
        // Create a new OpenFileDialog instance
        OpenFileDialog openFileDialog = new OpenFileDialog();

        // Set the properties for the dialog
        openFileDialog.Title = "Select a file";
        openFileDialog.Filter = "All Files (*.*)|*.*"; // You can filter specific file types like "*.txt", "*.jpg" etc.

        // Show the dialog and check if the user selected a file
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            // Get the selected file path
            string selectedFilePath = openFileDialog.FileName;

            // Display the file path (for example, in a message box)
            textBox1.Text = selectedFilePath;
        }
        else
        {
            MessageBox.Show("No file selected.");
        }
    }

    private void btnEncrypt_Click(object sender, EventArgs e)
    {
        string inputPath = textBox1.Text;
        string outputPath = inputPath + ".encrypted"; // Add ".encrypted" to the output file name

        if (string.IsNullOrEmpty(inputPath))
        {
            MessageBox.Show("Please enter the input file path.");
            return;
        }

        try
        {
            encryptor.EncryptFile(inputPath, outputPath);
            File.Delete(inputPath);
            MessageBox.Show("File encrypted successfully.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Encryption failed: " + ex.Message);
        }
    }

    private void btnDecrypt_Click(object sender, EventArgs e)
    {
        string inputPath = textBox1.Text;
        string outputPath = inputPath.Replace(".encrypted", ""); // Remove ".encrypted" from the output file name

        if (string.IsNullOrEmpty(inputPath))
        {
            MessageBox.Show("Please enter the encrypted file path.");
            return;
        }

        try
        {
            encryptor.DecryptFile(inputPath, outputPath);
            File.Delete(inputPath);
            MessageBox.Show("File decrypted successfully.");
        }   
        catch (Exception ex)
        {
            MessageBox.Show("Decryption failed: " + ex.Message);
        }
    }
}
