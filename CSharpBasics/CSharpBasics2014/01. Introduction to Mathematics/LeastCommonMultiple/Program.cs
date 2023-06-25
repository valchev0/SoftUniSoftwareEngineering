using System;
using System.Numerics;

class LeastCommonMultiple
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        bool indicator = false;
        bool breaker = false;

        //Find the smallest positive integer that is divisible by both numbers A & B – Least Common Multiple(A, B)

        if (a == 0)
        {
            Console.WriteLine("Least Common Multiple is 0.");
            breaker = true;
        }
        else if (b == 0)
        {
            Console.WriteLine("Least Common Multiple is 0.");
            breaker = true;
        }
        if(!breaker)
        {
            int minFromFirstAndSeond = Math.Min(a, b);
            int gcd = int.MinValue;  // Greatest Common Divisor
            for (int i = 2; i <= minFromFirstAndSeond; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
            }
            int lcm = int.MaxValue; // Least Common Multiple
            for (int i = gcd; i >= 2; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    lcm = i;
                    indicator = true;
                }
            }
            if (indicator)
            {
                Console.WriteLine("Least Common Multiple {0}.", lcm);
            }
            else
            {
                Console.WriteLine("There is no Common Divisor.");
            }
        }
    }
}