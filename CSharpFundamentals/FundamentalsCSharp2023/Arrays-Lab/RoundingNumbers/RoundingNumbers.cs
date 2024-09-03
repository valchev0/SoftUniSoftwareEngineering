using System;

namespace RoundingNumbers
{
    internal class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int rounded = (numbers[i] < 0)
                    ? (int)(numbers[i] - 0.5)
                    : (int)(numbers[i] + 0.5);

                Console.WriteLine("{0} => {1}", numbers[i], rounded);
            }
        }
    }
}