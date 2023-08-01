using System;

namespace GreatestCommonDivisor
{
    internal class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int min = Math.Min(a, b);
            int gcd = 0;

            for (int i = 1; i <= min; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    gcd = i;
                }
            }
            Console.WriteLine("GCD = {0}", gcd);
        }
    }
}