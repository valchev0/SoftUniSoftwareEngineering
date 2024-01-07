﻿using System;

namespace TopIntegers
{
    internal class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                bool isBigger = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isBigger = false;
                    }
                }
                if (isBigger)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
        }
    }
}