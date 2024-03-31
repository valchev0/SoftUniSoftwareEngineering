using System;
using System.ComponentModel.Design;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            int[] arr = GetMultipleOfEvenAndOdds(n);
            int evenSum = GetSumOfEvenDigits(arr);
            int oddSum = GetSumOfOddDigits(arr);

            int result = evenSum * oddSum;
            Console.WriteLine(result);

        }
        static int[] GetMultipleOfEvenAndOdds(int n)
        {
            int[] arr = new int[n.ToString().Length];
            int nCopy = n;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr[i] = nCopy % 10;
                nCopy /= 10;
            }
            return arr;
        }

        static int GetSumOfOddDigits(int[] arr)
        {
            int oddSum = 0;
            foreach (int index in arr)
            {
                if (index % 2 != 0)
                {
                    oddSum += index;
                }
            }
            return oddSum;
        }

        static int GetSumOfEvenDigits(int[] arr)
        {
            int evenSum = 0;
            foreach (int index in arr)
            {
                if (index % 2 == 0)
                {
                    evenSum += index;
                }
            }
            return evenSum;
        }

    }
}