using System;
class FileDetailsConstructors
{

    string filename = "Student1_Resume.docx";
    string filelocation = @"D:\Students\Resumes";
    string filesize = "2Kb";
    string createddate = "Mar-01-2024";
    DateTime createdDateTime = DateTime.Now;

    //0 param constructor
    public FileDetailsConstructors()
    {
        Console.WriteLine("File object created");
        Console.WriteLine(this.filename); // "Student1_Resume.docx"
        Console.WriteLine(this.createdDateTime);
        this.filename = "Sam_resume.docx"; //changing Student_Resume to Sam_resume

    }
    //2 param constructor
    public FileDetailsConstructors(string filename,string filesize)
    {
        this.filename = filename;
        this.filesize = filesize;
        Console.WriteLine("Param Constructor called.\nFile object created");
        Console.WriteLine(this.filename);
        Console.WriteLine(this.filesize);
        Console.WriteLine(this.createdDateTime);
    }

    static void Main()
    {
        FileDetailsConstructors file1 = new FileDetailsConstructors();

        //Note :  changed the filename inside of the constrcutor.

        Console.WriteLine(file1.filename);  //Sam_resume.docx

        FileDetailsConstructors file2 = new FileDetailsConstructors("File 2 CV","44Kb");

    }




}