using System;

namespace MultiplyEvensByOdds
{
    internal class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            input = FinalResult(input);
        }

        private static int FinalResult(int input)
        {
            int lastDigit = 0;
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;
            while (input > 0)
            {
                lastDigit = input % 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                else
                {
                    oddSum += lastDigit;
                }
                input /= 10;
            }
            result = evenSum * oddSum;
            Console.WriteLine(result);
            return input;
        }
    }
}