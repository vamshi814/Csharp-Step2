using System;

using ExcelFileSystem;
namespace MainProgramSystem
{
    class MainProgram
    {
        public static void Main()
        {
            //for accessing Jan_Files class in namespace excelFileSystem we use 
            //ExcelFileSystem . inside we able to see classes 
            ExcelFileSystem.Jan_Files JanFileExcel = new ExcelFileSystem.Jan_Files();
           Console.WriteLine("Excel file of Jan: " + JanFileExcel.filename);
            Feb_Files FebFileExcel = new Feb_Files();// bcz we used using ExcelFileSystem;
                                                     // so we can access the classes inside of ExcelFileSystem
                                                     // without namespace name 


            //we have two classes of same name in different namespaces 
            //so we have to specify them with their names

            PPTFileSystem.Jan_Files JanFilePPt = new PPTFileSystem.Jan_Files();
            Console.WriteLine("PPt file of Jan: " + JanFilePPt.filename);


        }
    }
}