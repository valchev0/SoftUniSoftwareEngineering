using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {


            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string restType = "";
            double budgetSpentPercentage = 0;

            if (budget <= 0)
            {
                Console.WriteLine("Invalid budget. Please enter a positive number.");
                return;
            }

            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        restType = "Camp";
                        budgetSpentPercentage = 0.3;
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                        restType = "Camp";
                        budgetSpentPercentage = 0.4;
                    }
                    else
                    {
                        destination = "Europe";
                        restType = "Hotel";
                        budgetSpentPercentage = 0.9;
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        restType = "Hotel";
                        budgetSpentPercentage = 0.7;
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                        restType = "Hotel";
                        budgetSpentPercentage = 0.8;
                    }
                    else
                    {
                        destination = "Europe";
                        restType = "Hotel";
                        budgetSpentPercentage = 0.9;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid season. Please enter either 'summer' or 'winter'.");
                    return;
            }

            double budgetSpent = budget * budgetSpentPercentage;
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{restType} - {budgetSpent:f2}");
        }
    }
}