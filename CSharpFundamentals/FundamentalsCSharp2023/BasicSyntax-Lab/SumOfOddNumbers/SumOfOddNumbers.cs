using System;

namespace SumOfOddNumbers
{
    internal class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int index = 1;
            int sum = 0;
            while (counter < n)
            {
                sum += index;
                Console.WriteLine(index);
                index += 2;
                counter++;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}