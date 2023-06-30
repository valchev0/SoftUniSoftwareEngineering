using System;

class MyConsoleApp
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Triangle area = {0}", ((a*h)/2));
    }
}
