using System;

namespace Flowers
{
    internal class Flowers
    {
        static void Main(string[] args)
        {
            int chrysanthemumsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char isBankHoliday = char.Parse(Console.ReadLine());

            double chrysanthemumsPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;
            double bouquetDiscount = 1;
            double bouquetAmountDiscount = 1;
            int amountFlowers = chrysanthemumsCount + rosesCount + tulipsCount;
            double bouquet = 2;
            double bankHolidayPromotiuon = 1;

            if (isBankHoliday == 'Y')
            {
                bankHolidayPromotiuon = 1.15;
            }

            switch (season)
            {
                case "Spring":
                    chrysanthemumsPrice = 2;
                    rosesPrice = 4.1;
                    tulipsPrice = 2.5;
                    if (tulipsCount > 7)
                    {
                       bouquetDiscount *= 0.95;
                    }
                    if (amountFlowers > 20)
                    {
                        bouquetAmountDiscount *= 0.8;
                    }
                    break;
                case "Summer":
                    chrysanthemumsPrice = 2;
                    rosesPrice = 4.1;
                    tulipsPrice = 2.5;
                    if (amountFlowers > 20)
                    {
                        bouquetAmountDiscount *= 0.8;
                    }
                    break;
                case "Autumn":
                    chrysanthemumsPrice = 3.75;
                    rosesPrice = 4.5;
                    tulipsPrice = 4.15;
                    if (amountFlowers > 20)
                    {
                        bouquetAmountDiscount *= 0.8;
                    }
                    break;
                case "Winter":
                    chrysanthemumsPrice = 3.75;
                    rosesPrice = 4.5;
                    tulipsPrice = 4.15;
                    if(rosesCount >= 10)
                    {
                        bouquetDiscount *= 0.9;
                    }
                    if (amountFlowers > 20)
                    {
                        bouquetAmountDiscount *= 0.8;
                    }
                    break;
            }
            double tulipsTotal = tulipsPrice * tulipsCount;
            double rosesTotal = rosesPrice * rosesCount;
            double chrysanthemumsTotal = chrysanthemumsPrice * chrysanthemumsCount;
            double flowersTotal = ((((tulipsTotal + rosesTotal + chrysanthemumsTotal) 
                * bankHolidayPromotiuon) * bouquetDiscount) * bouquetAmountDiscount) + 2;
            Console.WriteLine("{0:f2}", flowersTotal);
        }
    }
}