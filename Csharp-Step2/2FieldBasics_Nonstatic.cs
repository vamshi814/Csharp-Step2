using System;
class FieldBasics_NonStatic
{
    //Fields are nothting but kind of variables which can hold the values. Value can be anything.
    //static members
    string fileName = "Ram_Resume.docx";   //filename is a field . string value.
    string fileLocation = @"D:\Students\Resumes";
    string fileSize = "2kb";
    string filecreatedDate = "Mar-01-2025";

    DateTime applyResumeDateAndTime = DateTime.Now;
    void ShowMessage(string filename, string filelocation)
    {
        //filename
        Console.WriteLine(this);
        Console.WriteLine($"Hello, File name is {this.fileName} and file location is {filelocation}");
    }


    void entireStudentDetails(string fileName, string fileLocation, string fileSize, string filecreatedDate, DateTime resumeApplyDate)
    {
        // i am not prining anything.
    }


    //so now details is expecting the instaice of the class.
    void entireStudentDetails1(FieldBasics_NonStatic details)
    {
        // i am not prining anything.
    }

    static void Main(string[] args)
    {
        //Notes : If you want to call the non-static members you should call throught instance of the class
        //with the help of "new" keyword you can create instance of the class
        FieldBasics_NonStatic fildBaiscsNonStatic = new FieldBasics_NonStatic(); //xyz is obj , ref of the instance of the class
        string studentFileName = fildBaiscsNonStatic.fileName;
        //Console.WriteLine(studentFileName);
        string studentFileLocation = fildBaiscsNonStatic.fileLocation;
        fildBaiscsNonStatic.ShowMessage(studentFileName, studentFileLocation);


        //FieldBasics_NonStatic rahimDetails = new FieldBasics_NonStatic();
        //rahimDetails.fileName = "Rahim_resume.docx";
        //rahimDetails.fileLocation = @"C:\samples\Resumes";
        //rahimDetails.fileSize = "1kb";
        //rahimDetails.filecreatedDate = "Apr-01-2024";
        //rahimDetails.applyResumeDateAndTime = DateTime.Now;

        //short cut key
        FieldBasics_NonStatic rahimDetails = new FieldBasics_NonStatic()
        {
            fileName = "Rahim_resume.docx",
            fileLocation = @"C:\samples\Resumes",
            fileSize = "1kb",
            filecreatedDate = "Apr-01-2024",
            applyResumeDateAndTime = DateTime.Now
        };

        rahimDetails.entireStudentDetails(rahimDetails.fileName, rahimDetails.fileLocation, rahimDetails.fileSize, rahimDetails.filecreatedDate, rahimDetails.applyResumeDateAndTime);

        rahimDetails.entireStudentDetails1(rahimDetails);



        //Console.WriteLine(file2.fileName);   //Ram_Resume.docx.
        //file2.entireStudentDetails()

        Console.WriteLine("Hello world");

        //fildBaiscsNonStatic.
        //Console.WriteLine(studentFileName);

        //DateTime Apply =  FieldBasics.applyResumeDateAndTime;
        //Console.WriteLine(Apply);



    }
}