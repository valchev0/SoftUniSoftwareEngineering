using System;

namespace _00_
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysHolidays = int.Parse(Console.ReadLine()) - 1;
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();

            double roomPrice = 0;
            double reductionPriceRoom = 1;
            double sum;
            double totalSum = 0;
            switch (room)
            {
                case "room for one person": roomPrice = 18; break;
                case "apartment": roomPrice = 25; break;
                case "president apartment": roomPrice = 35; break;
            }
            if (room == "apartment" && daysHolidays < 10)
            {
                reductionPriceRoom = 0.7;
            }
            else if (room == "apartment" && daysHolidays > 15)
            {
                reductionPriceRoom = 0.5;
            }
            else if (room == "apartment" && daysHolidays >= 10 || room == "aprtment" && daysHolidays <= 15)
            {
                reductionPriceRoom = 0.65;
            }

            if (room == "president apartment" && daysHolidays < 10)
            {
                reductionPriceRoom = 0.9;
            }
            else if (room == "president apartment" && daysHolidays > 15)
            {
                reductionPriceRoom = 0.8;
            }
            else if (room == "president apartment" && daysHolidays >= 10 || room == "president aprtment" && daysHolidays <= 15)
            {
                reductionPriceRoom = 0.85;
            }
            sum = roomPrice * daysHolidays * reductionPriceRoom;
            switch (feedback)
            {
                case "positive": totalSum = sum + (sum * 0.25); break;
                case "negative": totalSum = sum * 0.9; break;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}