using System;

namespace SumMinMaxFirstLastAverage

{
    internal class SumMinMaxFirstLastAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Console.WriteLine(string.Join(" ", arr));

            int sum = arr.Sum();
            int min = arr.Min();
            int max = arr.Max();
            int first = arr.First();
            int last = arr.Last();
            decimal average = (decimal)arr.Average();

            Console.WriteLine("Sum = {0} \nMin = {1} \nMax = {2} \nFirst = {3} \nLast = {4} \nAverage = {5}",
                sum, min, max, first, last, average);
        }
    }
}