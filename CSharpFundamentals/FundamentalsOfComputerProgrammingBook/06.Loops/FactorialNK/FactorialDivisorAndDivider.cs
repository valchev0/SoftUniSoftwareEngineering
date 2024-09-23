using System;
using System.Numerics;

namespace FactorialDivisorAndDivider
{
    internal class FactorialDivisorAndDivider
    {
        static void Main(string[] args)
        {
            //N!/K! 
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger divisor = 1;
            BigInteger divider = 1;
            bool isDone = false;
            BigInteger sum = 0;

            while (!isDone)
            {
                while (n > 0)
                {
                    divisor *= n;
                    n--;
                }
                Console.WriteLine("Divisor is: {0}", divisor);
                while (k > 0)
                {
                    divider *= k;
                    k--;
                }
                Console.WriteLine("Divider is: {0}", divider);
                sum = divisor / divider;
                Console.WriteLine("!N/!K: {0}", sum);
                isDone = true;
            }
        }
    }
}