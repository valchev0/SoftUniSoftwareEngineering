using System;
namespace OddEvenSum
{
    internal class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }
            int diffrence = Math.Abs(oddSum - evenSum);
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes \nSum = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No \nDiff = {0}", diffrence);
            }
        }
    }
}