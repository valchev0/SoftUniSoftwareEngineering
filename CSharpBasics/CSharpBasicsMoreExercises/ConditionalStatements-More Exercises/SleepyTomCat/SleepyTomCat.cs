using System;
namespace SleepyTomCat
{
    internal class SleepyTomCat
    {
        static void Main(string[] args)
        {
            int normalPlayTime = 30_000;
            int playPerWorkingDay = 63;
            int playPerDayOff = 127;
            int daysPerYear = 365;

            int daysOff = int.Parse(Console.ReadLine());
            int workingDays = daysPerYear - daysOff;
            int daysOffMinutes = daysOff * playPerDayOff;
            int workingDaysMinutes = workingDays * playPerWorkingDay;
            int playedMinutesTotal = daysOffMinutes + workingDaysMinutes;
            int diffrence = Math.Abs(playedMinutesTotal - 30_000);
            int diffrenceHours = diffrence / 60;
            int diffrenceMinutes = diffrence % 60;

            if (playedMinutesTotal >= 30_000)
            {
                Console.WriteLine("Tom will run away \n{0} hours and {1} minutes more for play", diffrenceHours, diffrenceMinutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well \n{0} hours and {1} minutes less for play", diffrenceHours, diffrenceMinutes);
            }
        }
    }
}
