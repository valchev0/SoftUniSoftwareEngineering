﻿using System;

class MyConsoleApp
{
    static void Main()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        // Изчисляване страните на правоъгълника:
        var width = Math.Max(x1, x2) - Math.Min(x1, x2);
        var height = Math.Max(y1, y2) - Math.Min(y1, y2);

        Console.WriteLine(width * height);
        Console.WriteLine(2 * (width + height));
    }
}
