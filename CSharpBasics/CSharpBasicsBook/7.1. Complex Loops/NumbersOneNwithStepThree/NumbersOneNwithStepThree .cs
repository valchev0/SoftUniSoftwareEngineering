﻿using System;

namespace NumbersOneNwithStepThree
{
    internal class NumbersOneNwithStepThree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}