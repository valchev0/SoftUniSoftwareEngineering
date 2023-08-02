﻿using System;

namespace BreakSum
{
    internal class BreakSum
    {
        static void Main(string[] args)
        {
            bool hasToEnd = false;
            for(int i = 1; i <= 3; i++)
            {
                if(!hasToEnd)
                {
                    for(int j = 3; j >= 1; j--)
                    {
                        if(i + j == 2)
                        {
                            hasToEnd = true;
                            break;
                        }
                        Console.WriteLine(i + " " + j);
                    }
                }
            }
        }
    }
}