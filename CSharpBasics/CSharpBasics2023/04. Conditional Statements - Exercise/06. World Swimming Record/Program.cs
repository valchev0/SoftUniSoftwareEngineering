using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double currentRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeNeededForOneMetreSwimming = double.Parse(Console.ReadLine());

            double secondsForWholeDistance = distance * timeNeededForOneMetreSwimming;
            double timeSlowedDown = Math.Floor(distance / 15);
            secondsForWholeDistance += timeSlowedDown * 12.5;

            if (secondsForWholeDistance < currentRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {secondsForWholeDistance:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {secondsForWholeDistance - currentRecord:f2} seconds slower.");
            }

        }
    }
}