using System;
using System.Numerics;

class GreatestCommonDivisor
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        bool indicator = false;
        bool breaker = false;

        //Find the largest positive integer that divides both numbers A & B without a remainder – GCD(A, B)

        if (a == 0)
        {
            Console.WriteLine("Greatest common divisor is {0}", b);
            breaker = true;
        }
        else if (b == 0)
        {
            Console.WriteLine("Greatest common divisor is {0}", a);
            breaker = true;
        }
        if (!breaker)
        {
            int minFromFirstAndSeond = Math.Min(a, b);
            int gcd = int.MinValue;  // Greatest Common Divisor
            for (int i = 2; i <= minFromFirstAndSeond; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                    indicator = true;
                }
            }
            if (indicator)
            {
                Console.WriteLine("Greatest Common Divisor is {0}.", gcd);
            }
            else
            {
                Console.WriteLine("There is no Common Divisor.");
            }
        }
    }
}