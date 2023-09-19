﻿using System;

namespace RefactorVolumeOfPyramid
{
    internal class RefactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double pyramidVolume = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {pyramidVolume:f2}");
        }
    }
}