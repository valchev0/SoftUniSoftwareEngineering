using System;

namespace MultiplyEvensByOdds
{
    internal class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            int numCopy = n;
            int evenSum = 0;
            int oddSum = 0;
            while (numCopy > 0)
            {
                var lastDigit = LastDigit(ref numCopy);
                evenSum = GetSumOfEvenDigits(lastDigit, evenSum);
                oddSum = GetSumOfOddDigits(lastDigit, oddSum);
            }
            var result = GetMultipleOfEvenAndOdds(evenSum, oddSum);

            Console.WriteLine(result);

            int LastDigit(ref int numCopy1)
            {
                int i = numCopy1 % 10;
                numCopy1 /= 10;
                return i;
            }

            int GetMultipleOfEvenAndOdds(int evenSum1, int oddSum1)
            {
                int result1 = evenSum1 * oddSum1;
                return result1;
            }

            int GetSumOfEvenDigits(int lastDigit1, int i1)
            {
                if (lastDigit1 % 2 == 0)
                {
                    i1 += lastDigit1;
                }

                return i1;
            }

            int GetSumOfOddDigits(int lastDigit2, int oddSum2)
            {
                if (lastDigit2 % 2 != 0)
                {
                    oddSum2 += lastDigit2;
                }

                return oddSum2;
            }
        }
    }
}