using System;

namespace Even_OddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            foreach (var num in numsArray)
            {
                if (num % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            int result = evenSum - oddSum;

            Console.WriteLine(result);

        }
    }
}