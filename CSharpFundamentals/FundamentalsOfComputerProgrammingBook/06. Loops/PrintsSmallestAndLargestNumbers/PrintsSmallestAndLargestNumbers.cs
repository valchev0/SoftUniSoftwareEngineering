using System;
namespace PrintsSmallestAndLargestNumbers
{
    internal class PrintsSmallestAndLargestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue; 
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > max)
                {
                    max = currentNum;
                }
                if (currentNum < min)
                {
                    min = currentNum;
                }
            }
            Console.WriteLine("Max number is {0}\nMin number is {1}", max, min);
        }
    }
}