using System;

namespace SumDigits
{
    internal class SumDigits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = 0;
            int sum = 0;

            while (n > 0)
            {
                lastDigit = n % 10;
                sum += lastDigit;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}