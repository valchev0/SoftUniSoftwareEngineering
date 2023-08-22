using System;

namespace IncreasingElements
{
    internal class IncreasingElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int increasingElements = 0;
            int prev = 0;
            int currentNum = 0;
            int maxSequence = 0;
            for (int i = 0; i < n; i++)
            {
                currentNum = int.Parse(Console.ReadLine());
                if (currentNum > prev)
                {
                    increasingElements++; 
                }
                else
                {
                    increasingElements = 1;
                }
                prev = currentNum;
                if (maxSequence < increasingElements)
                {
                    maxSequence = increasingElements;
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}