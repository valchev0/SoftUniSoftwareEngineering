using System;
namespace SumFibonacciSequence
{
    internal class SumFibonacciSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int lastNum = 0;
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                Console.Write(lastNum + " ");
                num = num + lastNum;
                lastNum = num - lastNum;
                sum += lastNum;
            }
            Console.WriteLine("\nSum is: {0}", sum);
        }
    }
}