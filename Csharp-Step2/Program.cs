using System;


//CLASS :  fundamental building lock of OOP in C#.
//It serves as a bluprint for mainting fields, properties, constructors, methods, delegates.

//Field(s): fields are variables that belong to a class.
//They represent the data that an object of the class can hold.

//Properties: Properties that provides controlled access
//to a class's fields using get and set accessors.

//Constructor(s): It’s a special method that is used to initialize objects.
//It is called when an instance of the class is created.

//Method(s): Methods are reusable blocks of code that perform specific tasks

//Delegate(s): A delegate in C# is a type-safe pointer to a method with a specific signature.

class FieldBasics
{
    //static members
    static string fileName = "Ram_Resume.docx";   //filename is a field . string value.
    static string filLocation = @"D:\Students\Resumes";
    static string fileSize = "2kb";
    static string filecreatedDate = "Mar-01-2025";

    static DateTime applyResumeDateAndTime = DateTime.Now;

    static void ShowMessage(string filename, string filelocation)
    {
        //filename 
        Console.WriteLine($"Hello, File name is {fileName} and file location is {filelocation}");
    }


    
    static void Main(string[] args)
    {
        string studentFileName = FieldBasics.fileName;
        //Console.WriteLine(studentFileName);

        string studentFileLocation = FieldBasics.filLocation;

        DateTime Apply = FieldBasics.applyResumeDateAndTime;
        //Console.WriteLine(Apply);

        FieldBasics.ShowMessage(studentFileName, studentFileLocation);



    }
    
}

