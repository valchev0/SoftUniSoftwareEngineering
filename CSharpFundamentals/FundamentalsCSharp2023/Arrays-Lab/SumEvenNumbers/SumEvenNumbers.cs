using System;

namespace SumEvenNumbers
{
    internal class SumEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int evenSum = 0;

            foreach (var n in array)
            {
                if (n % 2 == 0)
                {
                    evenSum += n;
                }
            }

            Console.WriteLine(evenSum);
        }
    }
}