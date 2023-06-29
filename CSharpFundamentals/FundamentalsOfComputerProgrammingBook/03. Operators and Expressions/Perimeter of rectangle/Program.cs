using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int perimeter = 2 * (a + b);
            Console.WriteLine(perimeter);
        }
    }
}