﻿using System;

namespace RoundingNumbers
{
    internal class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {((int)Math.Round(numbers[i], MidpointRounding.AwayFromZero))}");
            }
        }
    }
}