using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace CondenseArrayToNumber
{
    internal class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (arr.Length > 1)
            {
                int[] condenced = new int[arr.Length - 1];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    condenced[i] = arr[i] + arr[i + 1];
                }
                arr = condenced;
            }
            Console.WriteLine(arr[0]);
        }
    }
}