using System;

namespace ZigZagArrays
{
    internal class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                counter++;
                int[] temporaryArray = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (counter % 2 == 1)
                {
                    firstArray[i] = temporaryArray[0];
                    secondArray[i] = temporaryArray[1];

                }
                else
                {
                    secondArray[i] = temporaryArray[0];
                    firstArray[i] = temporaryArray[1];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}