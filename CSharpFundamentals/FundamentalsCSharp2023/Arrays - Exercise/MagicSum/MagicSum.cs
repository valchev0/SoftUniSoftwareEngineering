using System;

namespace MagicSum
{
    internal class MagicSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] != array[j])
                    {
                        if (array[i] + array[j] == sum)
                        {
                            Console.WriteLine(array[i] + " " + array[j]);
                        }
                    }
                }
            }
        }
    }
}