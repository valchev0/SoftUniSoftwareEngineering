using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double parameter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("{0:f2}", area);
            Console.WriteLine("{0:f2}", parameter);
        }
    }
}