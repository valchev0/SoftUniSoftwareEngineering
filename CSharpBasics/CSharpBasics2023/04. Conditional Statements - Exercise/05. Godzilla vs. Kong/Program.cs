using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double extrasCount = double.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double moneyNeeded = budget * 0.1;
            double totalClothingPrice = extrasCount* clothingPrice;

            if (extrasCount > 150)
            {
                totalClothingPrice *= 0.9;
            }
            moneyNeeded += totalClothingPrice;

            if (moneyNeeded <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - moneyNeeded:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded - budget:f2} leva more.");
            }
        }
    }
}