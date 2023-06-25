using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 24, 101, 251 };
        foreach (int number in numbers)
        {
            Console.WriteLine("Is {0} prime? {1}", number, IsPrime(number));
        }
    }
}