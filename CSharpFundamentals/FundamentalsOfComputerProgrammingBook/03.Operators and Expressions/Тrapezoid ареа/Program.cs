using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int area = (a + b) / 2 * h;
            Console.WriteLine(area);
        }
    }
}