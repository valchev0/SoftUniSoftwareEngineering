using System;

namespace Factorial
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i ++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}