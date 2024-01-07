using System;

namespace EqualSum
{
    internal class EqualSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }
                for (int k = 0; k < i; k++)
                {
                    leftSum += array[k];
                }
                if (leftSum == rightSum)
                {
                    Console.Write("{0} ", i);
                    isFound = true;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}