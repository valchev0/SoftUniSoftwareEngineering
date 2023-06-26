using System;

class SomePrimes
{
    static void Main()
    {
        int primeIndex = 1;
        int number = 3;
        while (primeIndex <= 251)
        {
            bool isPrime = true;
            int maxDivider = (int)Math.Sqrt(number);
            for (int divider = 2; divider <= maxDivider; divider++)
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                if (primeIndex == 24 || primeIndex == 101 || primeIndex == 251)
                {
                    Console.WriteLine(primeIndex + "th prime number is: " + number);
                }
                primeIndex++;
            }
            number++;
        }
    }
}