using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool thirdBit = (number & (1 << 2)) != 0;
            Console.WriteLine(thirdBit);
        }
    }
}