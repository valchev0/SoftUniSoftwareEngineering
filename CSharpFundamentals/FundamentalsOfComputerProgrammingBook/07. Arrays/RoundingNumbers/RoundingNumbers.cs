using System;
using System.Linq;
using System.Numerics;

namespace RoundingNumbers
{
    internal class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} => {1}", arr[i], (int)Math.Round(arr[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}