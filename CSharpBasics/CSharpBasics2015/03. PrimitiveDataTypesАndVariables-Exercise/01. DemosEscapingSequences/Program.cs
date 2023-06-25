using System;

class DemosEscapingSequencess
{
    static void Main()
    {
        char apostrof = '\'';
        Console.WriteLine(apostrof);
        string stringApostrof = "\"";
        Console.WriteLine(stringApostrof);
        string directory = "C:\\Documents";
        Console.WriteLine(directory);
        string directoryAdd = @"C:\Documents";
        Console.WriteLine(directoryAdd);
        string directoryAddBackSlash = @"C:\Documents \n";
        Console.WriteLine(directoryAddBackSlash);
        string directoryAddBackSlashApostrof = @"C:\Docu""ments \n";
        Console.WriteLine(directoryAddBackSlashApostrof);
        char symbol = '\u00ff';
        Console.WriteLine(symbol);
        string hello = @"Hello, 
                        C#";
        Console.WriteLine(hello);
    }
}
