using System;
using System.Numerics;

namespace GreatestCommonDivisor
{
    internal class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int smallestNumber = Math.Min(n, k);
            bool isfound = false;
            int cgd = 0;
            for (int i = 2; i <= smallestNumber; i++)
            {
                if(n % i == 0 && k % i == 0)
                {
                    isfound = true;
                    cgd = i;
                }
            }
            if (isfound)
            {
                Console.WriteLine("Greatest common divisor of {0} and {1} is {2}.", n, k, cgd);
            }
            else
            {
                Console.WriteLine("There is no common divisor.");
            }
        }
    }
}