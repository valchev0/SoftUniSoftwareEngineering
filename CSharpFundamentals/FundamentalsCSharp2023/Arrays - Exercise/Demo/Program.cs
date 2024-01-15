using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int[] array = new int[n];
            int sum = 0;
            int bestSum = 0;


            while ((input = Console.ReadLine()) != "Clone them!") 
            {
                array = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                sum = array.Sum();
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
    }
}