using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace PdfSearch_demol;

internal class SearchService
{
    public static void SearchFileName(ListBox lstResult, TextBox txtFolderPath, TextBox txtSearchTerm)
    {
        // Get all PDF files in the directory and subdirectories
        var files = Directory.GetFiles(txtFolderPath.Text, "*.pdf", SearchOption.AllDirectories);

        // Filter the files where the name contains the search term
        var foundFiles = files.Where(file => Path.GetFileName(file)
            .Contains(txtSearchTerm.Text, StringComparison.OrdinalIgnoreCase));

        // Use Invoke to clear the ListBox on the UI thread
        lstResult.Invoke(new Action(() => lstResult.Items.Clear()));

        // Add only the file name (without the path) to the ListBox
        foreach (var file in foundFiles)
        {
            string fileName = Path.GetFileName(file);

            // Use Invoke to add items to the ListBox on the UI thread
            lstResult.Invoke(new Action(() =>
            {
                lstResult.Items.Add(fileName);
            }));
        }
    }

    public static void SearchFileContent(ListBox lstResult, TextBox txtFolderPath, TextBox txtSearchTerm)
    {
        string executingDirectory = txtFolderPath.Text;
        string textToFind = txtSearchTerm.Text;

        DirectoryInfo directoryInfo = new DirectoryInfo(executingDirectory);
        FileInfo[] fileInfos = directoryInfo.GetFiles("*.pdf");

        foreach (FileInfo fileInfo in fileInfos)
        {
            bool foundText = false;

            using (FileStream fileStream = File.OpenRead(fileInfo.FullName))
            using (PdfReader pdfReader = new PdfReader(fileStream))
            using (PdfDocument pdfDocument = new PdfDocument(pdfReader))
            {
                for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
                {
                    PdfPage pdfPage = pdfDocument.GetPage(page);
                    string pageText = PdfTextExtractor.GetTextFromPage(pdfPage, new SimpleTextExtractionStrategy());

                    if (pageText.Contains(textToFind, StringComparison.OrdinalIgnoreCase))
                    {
                        foundText = true;
                        break;
                    }
                }
            }

            // Safely update the ListBox on the UI thread
            if (foundText)
            {
                var found = $"{fileInfo.Name}";

                // Use Invoke to marshal back to the UI thread
                lstResult.Invoke(new Action(() =>
                {
                    lstResult.Items.Add(found);
                }));
            }
        }
    }

    public static void SearchFileContentWithPage(ListBox lstResult, TextBox txtFolderPath, TextBox txtSearchTerm)
    {
        string executingDirectory = txtFolderPath.Text;
        string textToFind = txtSearchTerm.Text;

        DirectoryInfo directoryInfo = new DirectoryInfo(executingDirectory);
        FileInfo[] fileInfos = directoryInfo.GetFiles("*.pdf");

        foreach (FileInfo fileInfo in fileInfos)
        {
            using FileStream fileStream = File.OpenRead(fileInfo.FullName);
            using PdfReader pdfReader = new PdfReader(fileStream);
            using PdfDocument pdfDocument = new PdfDocument(pdfReader);
            for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
            {
                PdfPage pdfPage = pdfDocument.GetPage(page);
                string pageText = PdfTextExtractor.GetTextFromPage(pdfPage, new SimpleTextExtractionStrategy());

                if (pageText.Contains(textToFind, StringComparison.OrdinalIgnoreCase))
                {
                    // Update the result with filename and page number
                    var found = $"{fileInfo.Name} - Page {page}";

                    // Use Invoke to marshal back to the UI thread
                    lstResult.Invoke(new Action(() =>
                    {
                        lstResult.Items.Add(found);
                    }));
                    break; // Stop searching once found on this file
                }
            }
        }
    }

    public static void SearchFileContentAllOccurences(ListBox lstResult, TextBox txtFolderPath, TextBox txtSearchTerm)
    {
        string executingDirectory = txtFolderPath.Text;
        string textToFind = txtSearchTerm.Text;

        DirectoryInfo directoryInfo = new DirectoryInfo(executingDirectory);
        FileInfo[] fileInfos = directoryInfo.GetFiles("*.pdf");

        foreach (FileInfo fileInfo in fileInfos)
        {
            using FileStream fileStream = File.OpenRead(fileInfo.FullName);
            using PdfReader pdfReader = new(fileStream);
            using PdfDocument pdfDocument = new(pdfReader);
            for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
            {
                PdfPage pdfPage = pdfDocument.GetPage(page);
                string pageText = PdfTextExtractor.GetTextFromPage(pdfPage, new SimpleTextExtractionStrategy());


                // Find all occurrences using IndexOf
                int index = pageText.IndexOf(textToFind, StringComparison.OrdinalIgnoreCase);
                while (index != -1)
                {
                    // Update the result with filename and page number
                    var found = $"{fileInfo.Name} - Page {page}";

                    // Use Invoke to marshal back to the UI thread
                    lstResult.Invoke(new Action(() => lstResult.Items.Add(found)));

                    // Find the next occurrence
                    index = pageText.IndexOf(textToFind, index + textToFind.Length, StringComparison.OrdinalIgnoreCase);
                }
            }
        }
    }

    public static void SearchFileContentCountOccurences(ListBox lstResult, TextBox txtFolderPath, TextBox txtSearchTerm)
    {
        string executingDirectory = txtFolderPath.Text;
        string textToFind = txtSearchTerm.Text;

        DirectoryInfo directoryInfo = new DirectoryInfo(executingDirectory);
        FileInfo[] fileInfos = directoryInfo.GetFiles("*.pdf");

        foreach (FileInfo fileInfo in fileInfos)
        {
            int occurrenceNumber = 1;
            using FileStream fileStream = File.OpenRead(fileInfo.FullName);
            using PdfReader pdfReader = new(fileStream);
            using PdfDocument pdfDocument = new(pdfReader);
            for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
            {
                PdfPage pdfPage = pdfDocument.GetPage(page);
                string pageText = PdfTextExtractor.GetTextFromPage(pdfPage, new SimpleTextExtractionStrategy());


                // Find all occurrences using IndexOf  
                int index = pageText.IndexOf(textToFind, StringComparison.OrdinalIgnoreCase);
                while (index != -1)
                {
                    // Only add file name once
                    if (occurrenceNumber == 1)
                    {
                        var fileName = fileInfo.Name;

                        // Use Invoke to marshal back to the UI thread
                        lstResult.Invoke(new Action(() => lstResult.Items.Add(fileName)));
                    }

                    // Update occurrence number
                    var found = $"Occurrences - {occurrenceNumber}";

                    // Use Invoke to marshal back to the UI thread
                    lstResult.Invoke(new Action(() => lstResult.Items.Add(found)));

                    occurrenceNumber++;

                    // Find the next occurrence
                    index = pageText.IndexOf(textToFind, index + textToFind.Length, StringComparison.OrdinalIgnoreCase);
                }
            }
        }
    }
}
