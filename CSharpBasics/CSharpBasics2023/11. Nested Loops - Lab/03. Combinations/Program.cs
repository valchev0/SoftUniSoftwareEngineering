﻿using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            for (int x1 = 0; x1 <= magicNumber; x1++)
            {
                for (int x2 = 0; x2 <= magicNumber; x2++)
                {
                    for (int x3 = 0; x3 <= magicNumber; x3++)
                    {
                        if (x1 + x2 + x3 == magicNumber) { combinations++; }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}