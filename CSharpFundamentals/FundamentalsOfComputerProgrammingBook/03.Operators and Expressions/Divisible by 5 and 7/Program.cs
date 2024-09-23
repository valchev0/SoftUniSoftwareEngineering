using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isTrue = true;
            if (n % 5 != 0 && n % 7 != 0)
            {
                isTrue = false;
            }
            if (isTrue)
            {
                Console.WriteLine("Divisible by 5 and 7");
            }
            else
                Console.WriteLine("Indivisible by 5 and 7");
        }
    }
}