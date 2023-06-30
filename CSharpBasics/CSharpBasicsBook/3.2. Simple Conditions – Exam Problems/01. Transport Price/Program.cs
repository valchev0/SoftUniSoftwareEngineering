using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string tariff = Console.ReadLine();

            double tariffPrice = 0;
            double startingPrice = 0;

            if (km >= 100)
            {
                tariffPrice = 0.06;
            }
            else if (km >= 20 && km < 100) 
            {
                tariffPrice = 0.09;
            }
            else
            {
                startingPrice = 0.7;
                switch (tariff)
                {
                    case "day":
                        tariffPrice = 0.79;
                        break;
                    case "night":
                        tariffPrice = 0.9;
                        break;
                }
            }
            double sum = (km * tariffPrice) + startingPrice;
            Console.WriteLine(sum);
        }
    }
}