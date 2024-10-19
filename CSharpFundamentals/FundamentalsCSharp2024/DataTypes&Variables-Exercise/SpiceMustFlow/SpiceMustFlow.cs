using System;

namespace SpiceMustFlow
{
    internal class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            const int MINIMUM_YEILD_PER_DAY = 100;
            const int CONSUMED_BY_THE_CREW = 26;
            const int DECREACES_PER_DAY = 10;
            int consumedSum = 0;
            int startingYeild = int.Parse(Console.ReadLine());
            int dayCounter = 0;
            while (startingYeild >= MINIMUM_YEILD_PER_DAY)
            {
                consumedSum += startingYeild;
                startingYeild -= DECREACES_PER_DAY;
                consumedSum -= CONSUMED_BY_THE_CREW;
                dayCounter++;
                if (startingYeild < MINIMUM_YEILD_PER_DAY)
                {
                    consumedSum -= CONSUMED_BY_THE_CREW;
                }
            }
            Console.WriteLine(dayCounter);
            Console.WriteLine(consumedSum);
        }
    }
}