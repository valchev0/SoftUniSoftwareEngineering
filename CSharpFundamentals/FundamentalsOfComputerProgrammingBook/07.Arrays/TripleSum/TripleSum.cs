using System;
using System.Linq;

namespace TripleSum

{
    internal class TripleSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", arr[i], arr[j], sum);
                        isFound = true;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}