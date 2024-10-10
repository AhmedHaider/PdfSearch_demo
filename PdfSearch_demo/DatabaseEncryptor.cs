using System.Security.Cryptography;
using System.Text;

namespace PdfSearch_demo;

internal class DatabaseEncryptor
{
    private readonly byte[] _key;
    private readonly byte[] _iv;

    public DatabaseEncryptor(string password)
    {
        _key = Encoding.UTF8.GetBytes(password.Substring(0, 32));
        _iv = Encoding.UTF8.GetBytes(password.Substring(32, 16));
    }

    public void EncryptFile(string inputPath, string outputPath)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = _key;
            aes.IV = _iv;
            using (FileStream fsInput = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fsOutput = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    using (CryptoStream cs = new CryptoStream(fsOutput, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] buffer = new byte[1024];
                        int read;
                        while ((read = fsInput.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            cs.Write(buffer, 0, read);
                        }
                    }
                }
            }
        }
    }

    public void DecryptFile(string inputPath, string outputPath)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = _key;
            aes.IV = _iv;
            using (FileStream fsInput = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fsOutput = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    using (CryptoStream cs = new CryptoStream(fsOutput, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        byte[] buffer = new byte[1024];
                        int read;
                        while ((read = fsInput.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            cs.Write(buffer, 0, read);
                        }
                    }
                }
            }
        }
    }
}
