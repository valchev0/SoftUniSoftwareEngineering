using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 251;
        int i = 2;
        int count = 0;

        while (count < n)
        {
            if (isPrime(i))
            {
                count++;
            }
            i++;
        }

        Console.WriteLine(i - 1);
    }

    static bool isPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}