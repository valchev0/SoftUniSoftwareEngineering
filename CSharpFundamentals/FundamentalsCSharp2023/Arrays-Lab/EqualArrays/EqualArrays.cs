using System;

namespace EqualArrays
{
    internal class EqualArrays
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isDiffrent = false;
            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isDiffrent = true;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                sum += firstArray[i];

                if (isDiffrent)
                {
                    break;
                }
            }

            if (!isDiffrent)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

            //string firstArrayAsString = string.Join("", firstArray);
            //string secondArrayAsString = string.Join("",  secondArray);

            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    sum += firstArray[i];
            //}

            //if (firstArrayAsString == secondArrayAsString)
            //{
            //    Console.WriteLine($"Arrays are identical. Sum: {sum}");
            //}
            //else
            //{
            //    Console.WriteLine();
            //}
        }
    }
}