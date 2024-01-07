using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
            int n = int.Parse(Console.ReadLine());

            int[] temp = new int[array.Length];

            for (
                int i = 0; i < n; i++)
            {
                int firstElement = array[0];
                for (int j = 1; j < temp.Length; j++)
                {
                    temp[j - 1] = array[j];
                }
                temp[temp.Length - 1] = firstElement;
                array = temp;
            }
            Console.WriteLine(string.Join(" ", temp));
        }
    }
}