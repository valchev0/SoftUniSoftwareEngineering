using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int workingDays = 365 - daysOff;
            int spentHours = (daysOff * 127) + (workingDays * 63);

            if (spentHours > 30_000)
            {
                Console.WriteLine("Tom will run away");
                int overHours = spentHours - 30_000;
                int hours = overHours / 60;
                int minutes = overHours % 60;
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                int lessHours = 30_000 - spentHours;
                int hours = lessHours / 60;
                int minutes = lessHours % 60;
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}