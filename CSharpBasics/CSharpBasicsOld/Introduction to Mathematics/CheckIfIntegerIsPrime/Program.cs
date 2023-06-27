using System;
using System.Numerics;

class CheckIfIntegerIsPrime
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (n <= 1)
        {
            Console.WriteLine("{0} is not prime.", n);
        }
        else if (n == 2)
        {
            Console.WriteLine("{0} is prime.", n);
        }
        for (int i = 2; i < n; i++)
        {
            if(n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (!isPrime)
        {
            Console.WriteLine("{0} is not prime.", n);
        }
        else
        {
            Console.WriteLine("{0} is prime.", n);
        }
    }
}