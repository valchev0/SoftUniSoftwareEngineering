using System;

namespace Even_OddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;
            int oddSum = 0;
            int diffrence = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) 
                {
                    evenSum += arr[i];
                }
                else
                {
                    oddSum += arr[i];
                }
            }
            diffrence = evenSum - oddSum;
            Console.WriteLine(diffrence);

        }
    }
}