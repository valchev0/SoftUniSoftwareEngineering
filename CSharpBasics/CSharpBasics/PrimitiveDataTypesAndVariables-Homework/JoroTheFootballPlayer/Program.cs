using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        char year = char.Parse(Console.ReadLine());
        bool isLeapYear = year == 't';
        int normalHolidays = int.Parse(Console.ReadLine()); // 1/2
        int weekendsInHome = int.Parse(Console.ReadLine());
        int weekendsPerYear = 52;                              // only onse per weekends if he's not in his hometown 
                                                           // and he's not tired
        double normalWeekends = weekendsPerYear - weekendsInHome;
        normalWeekends /= 3;
        double playCounter = 0;
        if (isLeapYear)
        {
            playCounter = 3;
        }
        playCounter += normalHolidays + normalWeekends;
        Console.WriteLine(playCounter);
    }
}