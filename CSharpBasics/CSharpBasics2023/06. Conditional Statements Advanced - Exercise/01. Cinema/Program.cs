﻿using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата: тип прожекция, брой редове и колони 
            string ticketType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            //2. Намираме колко са свободните места в залата
            double income = row * col;

            //3. Проверки каква е прожекцията
            switch (ticketType)
            {
                case "Premiere":
                    income *= 12;
                    break;
                case "Normal":
                    income *= 7.50;
                    break;
                case "Discount":
                    income *= 5;
                    break;
            }

            //4. Отпечатваме резултата на конзолата
            Console.WriteLine("{0:f2} leva", income);

        }
    }
}
