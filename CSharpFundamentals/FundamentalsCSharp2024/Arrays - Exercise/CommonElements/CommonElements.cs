using System;
using System.Diagnostics.Metrics;

namespace CommonElements
{
    internal class CommonElements
    {
        static void Main(string[] args)
        {
            string[] secondArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] firstArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] commonElements = new string[firstArray.Length];
            
            int counter = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        commonElements[counter] = firstArray[i];
                        counter++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", commonElements));

        }
    }
}