﻿using System;

class MyConsoleApp
{
    static void Main()
    {
        var b1 = double.Parse(Console.ReadLine());
        var b2 = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
        var area = (b1 + b2) * h / 2.0;
        Console.WriteLine("Trapezoid area = " + area);
    }
}
