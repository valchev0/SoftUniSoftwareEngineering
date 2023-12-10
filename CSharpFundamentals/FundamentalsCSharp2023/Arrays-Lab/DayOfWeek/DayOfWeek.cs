﻿using System;

namespace DayOfWeek
{
    internal class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = 
            { 
                "Monday", 
                "Tuesday", 
                "Wednesday", 
                "Thursday", 
                "Friday", 
                "Saturday", 
                "Sunday" 
            };

            int day = int.Parse(Console.ReadLine());

            if (day > 0 && day <= 7)
            {
                Console.WriteLine(dayOfWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}