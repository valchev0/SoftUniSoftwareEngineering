﻿using System;

class MyConsoleApp
{
    static void Main()
    {
        Console.WriteLine("enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int x = i; x <= n; x++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
    }
}
