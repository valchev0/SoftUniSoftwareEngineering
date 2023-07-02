﻿using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double tripCost =double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double totalSum = (puzzlesCount * 2.6) + (dollsCount * 3.0) + (bearsCount * 4.1) + (minionsCount * 8.2) + (trucksCount * 2);

            int toysCount = puzzlesCount + dollsCount + bearsCount + minionsCount + trucksCount;

            if (toysCount >= 50) 
            {
                totalSum = totalSum * 0.75;

            }
            totalSum = totalSum * 0.9;

            if (totalSum >= tripCost)
            {
                Console.WriteLine($"Yes! {totalSum - tripCost:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripCost - totalSum:f2} lv needed.");
            }
        }
    }
}