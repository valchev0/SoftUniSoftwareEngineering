﻿using System;

namespace ArrayRotation
{
    internal class ArrayRotation
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int firstElement = array[0];

                int[] temp = new int[array.Length];

                for (int j = 1; j < temp.Length; j++)
                {
                    temp[j - 1] = array[j];
                }
                temp[temp.Length - 1] = firstElement;
                array = temp;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}