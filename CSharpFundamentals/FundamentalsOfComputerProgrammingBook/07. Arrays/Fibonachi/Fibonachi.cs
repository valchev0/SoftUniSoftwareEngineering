using System;

namespace Fibonacci
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factZero = 1;
            int factOne = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int factNext = factZero + factOne;
                factZero = factOne;
                factOne = factNext;
            }
            Console.WriteLine(factOne);
        }
    }
}