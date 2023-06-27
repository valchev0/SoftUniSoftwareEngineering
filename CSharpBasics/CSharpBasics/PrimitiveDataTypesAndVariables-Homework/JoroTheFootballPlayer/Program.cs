using System;
using System.Diagnostics.SymbolStore;

class JoroTheFootballPlayer
{
    static void Main()
    {
       double weekendsPerYear = 52;
        char yearType = char.Parse(Console.ReadLine());
        bool isLeapYear = yearType == 't';
        double holidaysNotWeekends = double.Parse(Console.ReadLine())/2;
        double weekendsHometown = double.Parse(Console.ReadLine());
        double playsWeekend = weekendsHometown + ((weekendsPerYear - weekendsHometown) * 2/3);
        double totalPlays = 0;
        if (isLeapYear)
        {
            totalPlays += 3;
        }
        totalPlays += holidaysNotWeekends + playsWeekend;
        Console.WriteLine(Math.Floor(totalPlays));
    }
}