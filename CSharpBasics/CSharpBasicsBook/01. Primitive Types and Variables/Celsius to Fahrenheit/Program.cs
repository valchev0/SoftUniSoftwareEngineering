using System;

class MyConsoleApp
{
    static void Main()
    {
        double celsius = double.Parse(Console.ReadLine());
        double farenheit = (celsius * 1.8) + 32;
        Console.WriteLine($"{farenheit:f2}");
    }
}
