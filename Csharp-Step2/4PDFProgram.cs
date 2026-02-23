using System;


// Array of classes passed through argument
class PDFFile
{
    //string _filename;      fields
    //string _filelocation;
    //string _filesize;
    //string _createddate;

    //properties - controlled access
    public string FileName { get; set; }
    public string FileLocation { get; set; }
    public string FileSize { get; set; }
    public string CreatedDate { get; set; }
}


class PDFFilesSystem
{
    public void ShowPDFFileNamesLength(string[] fileNames)
    {
        Console.WriteLine($"The total pdfs are : {fileNames.Length}");
        //Code here......
    }

    public void PrintEveryPDFFileName(string[] fileNames)
    {
        Console.WriteLine("Printing Every PDF file name");
        foreach (string fileName in fileNames)
        {
            Console.WriteLine($"file name is : {fileName}");
        }
        
    }

    public void PrintEveryPDFFileDetails(PDFFile[] files)
    {
        Console.WriteLine("File in files[]: ");
        int i = 1;
        foreach (PDFFile file in files)
        {
           // i += 1;
            Console.WriteLine($"The file {i++}:");
            Console.WriteLine($"file name is : {file.FileName}");
            Console.WriteLine($"file name is : {file.FileSize}");
            Console.WriteLine($"file name is : {file.FileLocation}");
            Console.WriteLine($"file name is : {file.CreatedDate}");
        }
    }
    public PDFFile getFirstPdf(PDFFile[] files)
    {
        return files[0];
    }

}


class PDFProgram
{

    static void Main()
    {
        PDFFilesSystem pdf = new PDFFilesSystem();

        string[] fileNames = { "PDFFile1.pdf", "PDFFile2.pdf", "PDFFile3.pdf" };

        pdf.ShowPDFFileNamesLength(fileNames);

        pdf.PrintEveryPDFFileName(fileNames);

        PDFFile[] allCreditCardStatementFiles = new PDFFile[]
        {
            new PDFFile()
                {
                    FileName = "CreditcardstatmentMarch.pdf",
                    CreatedDate = "Mar-01-2025",
                    FileSize = "5kb",
                    FileLocation = @"C:/Downloads"
                },
            new PDFFile()
                {
                    FileName = "CreditcardstatmentApril.pdf",
                    CreatedDate = "April-01-2025",
                    FileSize = "4kb",
                    FileLocation = @"C:/Downloads"
                },
            new PDFFile()
                {
                    FileName = "CreditcardstatmentMay.pdf",
                    CreatedDate = "May-01-2025",
                    FileSize = "3kb",
                    FileLocation = @"C:/Downloads"
                }
          };

        pdf.PrintEveryPDFFileDetails(allCreditCardStatementFiles);

        PDFFile p1 = pdf.getFirstPdf(allCreditCardStatementFiles);
        Console.WriteLine($"The first file name is : {p1.FileName}");
    }

}