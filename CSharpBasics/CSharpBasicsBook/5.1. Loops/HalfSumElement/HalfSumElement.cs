using System;
namespace HalfSumElement
{
    internal class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > max)
                {
                    max = currentNum;
                }
                sum += currentNum;
            }
            int clearSum = Math.Abs(sum - max);
            if (clearSum == max)
            {
                Console.WriteLine("Yes \nSum = {0}", clearSum);
            }
            else
            {
                int diffrence = Math.Abs(clearSum - max);
                Console.WriteLine("No \nDiff = {0}", diffrence);
            }
        }
    }
}