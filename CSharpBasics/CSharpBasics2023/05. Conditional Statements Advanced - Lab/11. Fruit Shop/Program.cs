using System;

namespace FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get input from user
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            // Check if fruit is valid
            if (fruit != "banana" && fruit != "apple" && fruit != "orange" && fruit != "grapefruit" && fruit != "kiwi" && fruit != "pineapple" && fruit != "grapes")
            {
                Console.WriteLine("error");
                return;
            }

            // Check if day is valid
            if (day != "Monday" && day != "Tuesday" && day != "Wednesday" && day != "Thursday" && day != "Friday" && day != "Saturday" && day != "Sunday")
            {
                Console.WriteLine("error");
                return;
            }

            // Declare variable to hold the price
            double price = 0;

            // Determine the price based on the day
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    // Determine the price based on the fruit
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.5;
                            break;
                        case "apple":
                            price = 1.2;
                            break;
                        case "orange":
                            price = 0.85;
                            break;
                        case "grapefruit":
                            price = 1.45;
                            break;
                        case "kiwi":
                            price = 2.7;
                            break;
                        case "pineapple":
                            price = 5.5;
                            break;
                        case "grapes":
                            price = 3.85;
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    // Determine the price based on the fruit
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.7;
                            break;
                        case "apple":
                            price = 1.25;
                            break;
                        case "orange":
                            price = 0.9;
                            break;
                        case "grapefruit":
                            price = 1.6;
                            break;
                        case "kiwi":
                            price = 3;
                            break;
                        case "pineapple":
                            price = 5.6;
                            break;
                        case "grapes":
                            price = 4.2;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }

            // Calculate the total price and display it
            double totalPrice = quantity * price;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}