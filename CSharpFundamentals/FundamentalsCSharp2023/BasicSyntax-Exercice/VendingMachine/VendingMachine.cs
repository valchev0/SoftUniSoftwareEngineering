using System;

namespace VendingMachine
{
    internal class VendingMachine
    {
        static void Main(string[] args)
        {
            string command;
            double piggyBank = 0;
            double coin = 0;

            while ((command = Console.ReadLine()) != "Start")
            {
                coin = double.Parse(command);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    piggyBank += coin;
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", coin);
                }
            }
            string product;
            while ((product = Console.ReadLine()) != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (piggyBank >= 2) 
                        {
                            piggyBank -= 2;
                            Console.WriteLine("Purchased {0}", product.ToLower());
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (piggyBank >= 0.7)
                        {
                            piggyBank -= 0.7;
                            Console.WriteLine("Purchased {0}", product.ToLower());
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (piggyBank >= 1.5)
                        {
                            piggyBank -= 1.5;
                            Console.WriteLine("Purchased {0}", product.ToLower());
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (piggyBank >= 0.8)
                        {
                            piggyBank -= 0.8;
                            Console.WriteLine("Purchased {0}", product.ToLower());
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (piggyBank >= 1)
                        {
                            piggyBank -= 1;
                            Console.WriteLine("Purchased {0}", product.ToLower());
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
            Console.WriteLine("Change: {0:0.00}", piggyBank);
        }
    }
}