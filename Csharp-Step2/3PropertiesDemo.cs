using System;
class StudentResume
{
    //Developer realted formula . _ that means that is field;
    //string _filename = "Ram_Resume.docx";   //field

    //properties we have control over getting , setting values. 
    //string AaadharNumber { get; }

    string FileName { get; set; }
    string FileLocation { get; set; }
    string FileSize { get; set; }
    string CreatedDate { get; set; }
    DateTime CreatedDateTime { get; set; }

    static void Main()
    {
        StudentResume sr = new StudentResume();
        sr.FileName = "Ram_reusme.docx";
        sr.FileLocation = @"C:\Students\Reumes";

        sr.FileSize = "1kb";
        sr.CreatedDate = "Jan-01-205";
        sr.CreatedDateTime = DateTime.Now;
        //demo.AaadharNumber = "qet";
        //demo.AaadharNumber = "afaasda";

    }

}