﻿using System;

namespace MultiplicationTable
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, (n * i));
            }
        }
    }
}