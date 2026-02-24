using System;
using System.Runtime.CompilerServices;
static class Logger
{
    //field
    static string fileName = "Dummy";

    //property
    static string LogFile {  get; set; }

    static Logger()
    {
        Logger.LogFile = fileName;
    }
    static void LogInfo(string fileName)
    {
        Console.WriteLine($"the logger started at {DateTime.Now}---{fileName}");
    }
    static void LogMessage(string level, string msg)
    {
        Console.WriteLine($"{DateTime.Now} - {level} - {msg}");
    }
    static void Warning(string msg)
    {
        LogMessage("Warning", msg);
    }
    static void Main()
    {
        Console.WriteLine($"The logger file field is {Logger.fileName}");
        Console.WriteLine($"The logger file property is {Logger.LogFile}");
        Logger.LogInfo("App1");
        Logger.LogMessage("Started", "Enjoy !!!");
        Logger.Warning("Entered so many wrong attempts!");


    }
}
