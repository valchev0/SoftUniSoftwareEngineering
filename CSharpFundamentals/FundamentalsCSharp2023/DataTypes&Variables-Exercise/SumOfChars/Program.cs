using System;

namespace SumOfChars
{
    internal class SumOfChars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            char chr = ' ';

            for (int i = 0; i < n; i++)
            {
                chr = char.Parse(Console.ReadLine());
                sum += chr;
            }
            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}