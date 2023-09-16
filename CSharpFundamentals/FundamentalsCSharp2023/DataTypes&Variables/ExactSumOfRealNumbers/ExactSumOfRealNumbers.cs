using System;

namespace ExactSumOfRealNumbers
{
    internal class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            decimal input = 0;

            for (int i = 0; i < n; i++)
            {
                input = decimal.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}