﻿using System;

namespace PointInFigure
{
    internal class PointInFigure
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());  
            if ((x >= 4 && 
                x <= 10 && 
                y <= 3 && 
                y >= -5) ||
                (x >= 2 && 
                x <= 12 && 
                y <= 1 && 
                y >= -3))
            {
                Console.WriteLine("in");
            }
            else { Console.WriteLine("out"); }
        }
    }
}