using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Четем от конзолата бюджет(int), сезон(string) и брой рибари(int)
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //"Spring", "Summer", "Autumn", "Winter"
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0;

            // 2. Проверяваме какъв е сезона => какъв е наема
            switch (season)
            {
                //•   пролет -3000 лв.
                case "Spring":
                    price = 3000;
                    break;
                //•   лятото или есента - 4200 лв.
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                //•   зимата - 2600 лв.
                case "Winter":
                    price = 2600;
                    break;
            }

            //3. Проверяваме каква отстъпка ще получат
            if (fishermen <= 6)
            {
                price = price - price * 0.10;
                // price -= price * 0.10;
            }
            else if (fishermen <= 11)
            {
                price -= price * 0.15;
            }
            else //fishermen >= 12
            {
                price -= price * 0.25;
            }

            //4. Проверяваме дали ще имат доп. отстъпка
            // => ако рибарите са четен брой и НЕ Е есен
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }

            //5. Проверяваме дали бюджета ще им стигне
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}