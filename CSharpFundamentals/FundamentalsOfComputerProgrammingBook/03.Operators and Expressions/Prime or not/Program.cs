using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("{0} is prime.", n);
            }
            else
            {
                Console.WriteLine("{0} is non-prime.", n);
            }
        }
    }
}