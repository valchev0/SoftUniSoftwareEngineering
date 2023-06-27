using System;
using System.Numerics;

class SomeFactorials
{
    static void Main(string[] args)
    {
        int[] numbers = { 100, 171, 250 };
        foreach (int number in numbers)
        {
            BigInteger factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}