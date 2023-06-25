using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class ExtractDateFromString
{
    static void Main()
    {
        string date = Console.ReadLine();
        var theDate = DateOnly.ParseExact(date, "dd MM yyyy",
            CultureInfo.InvariantCulture);
        Console.WriteLine(theDate);
    }
}
