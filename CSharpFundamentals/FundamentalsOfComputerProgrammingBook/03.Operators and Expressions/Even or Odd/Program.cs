using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
                Console.WriteLine("Odd");
        }
    }
}