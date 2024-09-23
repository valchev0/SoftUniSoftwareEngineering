using System;

namespace DigitContainsInArray
{
    internal class DigitContainsInArray
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.Write("Choose a number: ");

            Console.WriteLine("The number was found {0} times", ContainCounter(arr));

        }
        static int ContainCounter(int[] arr)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                    counter++;
            }
            return counter;
        }
    }
}
