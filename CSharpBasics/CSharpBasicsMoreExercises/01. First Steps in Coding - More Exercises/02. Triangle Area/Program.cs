using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = (a * height) / 2;

            Console.WriteLine($"{area:f2}");
        }
    }
}