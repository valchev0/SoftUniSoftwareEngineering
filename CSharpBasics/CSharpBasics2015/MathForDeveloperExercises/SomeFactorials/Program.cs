using System;
using System.Numerics;

class SomeFactorials
{
    static void Main()
    {
        ulong factorial = ulong.Parse(Console.ReadLine());
        BigInteger n = factorial;
        ulong factorialSum = 1;
        ulong factorialCopy = factorial;
        ulong max = 7922816251426433759;
        ulong previusNumber = 1;
        for (ulong i = 1; i <= n; i++)
        {
            if (factorial > 1)
            {
                factorialSum *= factorial;
                factorial--;
            }
        }
        Console.WriteLine(factorialSum);
    }
}