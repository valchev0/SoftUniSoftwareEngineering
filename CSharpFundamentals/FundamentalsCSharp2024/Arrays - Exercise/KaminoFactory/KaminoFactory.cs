using System;

namespace KaminoFactory
{
    internal class KaminoFactory
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int dnaLength = int.Parse(input);
            int[] array = new int[dnaLength];
            int[] bestDNA = new int[dnaLength];
            int counter = 0;
            int dnaCounter = 1;
            int bestDNACounter = 1;
            int startIndex = 0;
            int besStartIndex = 1;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                counter++;
                for (int i = 0; i < dnaLength; i++)
                {
                    array = input
                        .Split('!', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    for (int j = 1; j < dnaLength; j++)
                    {
                        if (array[j] == array[j - 1])
                        {
                            dnaCounter++;
                        }
                        else
                        {
                            dnaCounter = 1;
                        }
                        if (j - 1 < besStartIndex && dnaCounter > bestDNACounter)
                        {
                            bestDNACounter = dnaCounter;
                            //startIndex = j - 1;
                            bestDNA = array.ToArray();
                            besStartIndex = j - 1;
                        }
                    }
                    //sum = array.Sum();
                    //if (sum > bestSum)
                    //{
                    //    bestSum = sum;
                    //    bestDNA = array;
                    //}
                }
            }
            Console.WriteLine("Best DNA sample {0} with sum: {1}.", counter, bestDNA.Sum());
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}