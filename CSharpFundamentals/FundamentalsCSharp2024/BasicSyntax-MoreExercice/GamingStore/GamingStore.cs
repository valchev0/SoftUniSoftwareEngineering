using System;

namespace GamingStore
{
    internal class GamingStore
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = string.Empty;
            double spentMoney = 0;
            bool loopbreaker = false;
            while (((command = Console.ReadLine()) != "Game Tine") && budget > 0)
            {
                switch (command)
                {
                    case "OutFall 4":
                        if (budget >= 39.99)
                        {
                            Console.WriteLine($"Bought {command}");
                            spentMoney += 39.99;
                            budget -= 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (budget >= 15.99)
                        {
                            spentMoney += 15.99;
                            budget -= 15.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (budget >= 19.99)
                        {
                            spentMoney += 19.99;
                            budget -= 19.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (budget >= 59.99)
                        {
                            spentMoney += 59.99;
                            budget -= 59.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (budget >= 29.99)
                        {
                            spentMoney += 29.99;
                            budget -= 29.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (budget >= 39.99)
                        {
                            spentMoney += 39.99;
                            budget -= 39.99;
                            Console.WriteLine($"Bought {command}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Game Time":
                        loopbreaker = true; break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (loopbreaker)
                {
                    break;
                }
            }
            if (budget > 0)
            {
                Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${budget:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}