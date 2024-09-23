using System;
using System.Linq;
using System.Numerics;

namespace SumArrays
{
    internal class SumArrays
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = Math.Max(firstArr.Length, secondArr.Length);

            int[] sumArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                sumArr[i] = firstArr[i % firstArr.Length]
                    + secondArr[i % secondArr.Length];
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}