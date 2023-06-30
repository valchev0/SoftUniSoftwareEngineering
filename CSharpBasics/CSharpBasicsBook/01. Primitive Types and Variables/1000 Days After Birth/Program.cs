using System;

class MyConsoleApp
{
    static void Main()
    {
        string input = Console.ReadLine(), format = "dd-MM-yyyy";
        DateTime date = DateTime
            .ParseExact(input, format, System
            .Globalization
            .CultureInfo
            .InvariantCulture);
        date = date.AddDays(1000);
        Console.WriteLine(date.ToString(format = "dd-MM-yyyy"));
    }
}
