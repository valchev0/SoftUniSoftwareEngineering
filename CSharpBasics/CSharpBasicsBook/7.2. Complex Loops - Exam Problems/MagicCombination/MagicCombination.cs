﻿using System;

namespace StupidPasswordGenerator
{
    internal class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for(int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            for (int m = 1; m <= 9; m++)
                            {
                                for (int n = 1; n <= 9; n++)
                                {
                                    int temp = (i * j * k * l * m * n);
                                    if (temp == num)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", i, j, k, l, m, n);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}