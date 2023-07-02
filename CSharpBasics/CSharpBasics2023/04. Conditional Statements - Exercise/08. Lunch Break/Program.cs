using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine(); 
            int episodeLength = int.Parse(Console.ReadLine());
            int wholeRestLength = int.Parse(Console.ReadLine());

            double lunchBreakLength = wholeRestLength / 8.0;
            double restLength = wholeRestLength / 4.0;
            double remainingTime = wholeRestLength - (lunchBreakLength + restLength);

            if (episodeLength <= remainingTime)
            {
                double timeLeft = Math.Ceiling(remainingTime - episodeLength);
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {timeLeft} minutes free time.");
            }
            else
            {
                double timeNeeded = Math.Ceiling(episodeLength - remainingTime);
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {timeNeeded} more minutes.");
            }
        }
    }
}