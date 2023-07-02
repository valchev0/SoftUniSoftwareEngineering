using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowersPrice = 0;
            switch (flowersType) 
            {
                case "Roses": flowersPrice= 5; break;
                case "Dahlias": flowersPrice= 3.8; break;
                case "Tulips": flowersPrice= 2.8; break;
                case "Narcissus": flowersPrice = 3; break;
                case "Gladiolus": flowersPrice= 2.5; break;
            }

            double totalSum = flowersCount * flowersPrice;

            if (flowersType == "Roses" && flowersCount > 80)
            {
                totalSum *= 0.9;
            }
            else if (flowersType == "Dahlias" && flowersCount > 90)
            {
                totalSum *= 0.85;
            }
            else if (flowersType == "Tulips" && flowersCount > 80)
            {
                totalSum *= 0.85;
            }
            else if (flowersType == "Narcissus" && flowersCount < 120)
            {
                totalSum *= 1.15;
            }
            else if (flowersType == "Gladiolus" && flowersCount < 80)
            {
                totalSum *= 1.2;
            }
            if (totalSum <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalSum - budget:f2} leva more.");
            }


        }
    }
}