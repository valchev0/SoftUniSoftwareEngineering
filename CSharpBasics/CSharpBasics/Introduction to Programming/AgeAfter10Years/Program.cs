using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the date, or write 'now': ");
        string date = Console.ReadLine();
        if (date == "now")
        {
            var theDate = DateTime.Now;
            var dateAfter10Years = theDate.AddYears(10);
            Console.WriteLine(dateAfter10Years);
            Console.WriteLine(age + 10);
        }
        else
        {
            var theDate = DateOnly.ParseExact(date, "dd MM yyyy",
                CultureInfo.InvariantCulture);
            var dateAfter10Years = theDate.AddYears(10);
            Console.WriteLine(dateAfter10Years);
            Console.WriteLine(age + 10);
        }
    }
}
