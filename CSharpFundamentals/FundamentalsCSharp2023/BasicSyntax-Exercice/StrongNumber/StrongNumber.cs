using System;
using System.Globalization;
using System.Numerics;

namespace StrongNumber
{
    internal class StrongNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numCopy = n;
            int lastDigit = 0;
            int factorial;
            int factorialSum = 0;

            while (n > 0)
            {
                lastDigit = n % 10;
                factorial = 1;
                if (lastDigit > 1)
                {
                    for (int i = 1; i <= lastDigit; i++)
                    {
                        factorial *= i;
                    }
                }
                factorialSum += factorial;
                n /= 10;
            }
            if (factorialSum == numCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}