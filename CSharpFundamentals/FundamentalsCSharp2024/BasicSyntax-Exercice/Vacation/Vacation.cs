using System;

namespace Vacation
{
    internal class Vacation
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double discount = 1;

            switch (groupType)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.8;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.9;
                            break;
                        case "Saturday":
                            price = 15.6;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.5;
                            break;
                    }
                    break;
            }
            if (groupType == "Students" && countPeople >= 30)
            {
                discount = 0.85;
            }
            else if (groupType == "Business" && countPeople >= 100)
            {
                countPeople -= 10;
            }
            else if (groupType == "Regular" && (countPeople >= 10 && countPeople <= 20))
            {
                discount = 0.95;
            }
            double totalPrice = (countPeople * price) * discount;
            Console.WriteLine("Total price: {0:0.00}", totalPrice);
        }
    }
}