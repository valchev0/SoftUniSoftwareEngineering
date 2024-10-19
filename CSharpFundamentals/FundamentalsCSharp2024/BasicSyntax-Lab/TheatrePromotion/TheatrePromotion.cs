using System;

namespace TheatrePromotion
{
    internal class TheatrePromotion
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            bool isError = false;

            if (age >= 0 && age <= 18)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 5;
                        break;
                    default: isError = true;
                        break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 18;
                        break;
                    case "Weekend":
                        price = 20;
                        break;
                    case "Holiday":
                        price = 12;
                        break;
                        default : isError = true;
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 10;
                        break;
                        default: isError =true; 
                        break;
                }
            }
            else
            {
                isError = true;
            }
            if (!isError)
            {
                Console.WriteLine("{0}$", price);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}