using System;

namespace SumDigits
{
    internal class SumDigits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = n;
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}