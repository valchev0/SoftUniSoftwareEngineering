using System;

namespace CondenseArrayToNumber
{
    internal class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int[] condensed = new int[array.Length];
            while (condensed.Length > 1)
            {
                condensed = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    condensed[i] = array[i] + array[i + 1];
                }
                array = condensed;
            }
            Console.WriteLine(array[0]);
        }
    }
}