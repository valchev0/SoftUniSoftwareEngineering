using System;

namespace PrintNumbersInReverseOrder
{
    internal class PrintNumbersInReverseOrder
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write(string.Join(' ', numbers.Reverse()));

            //OR
            //int length = int.Parse(Console.ReadLine());
            //int[] numbers = new int[length];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
        }
    }
}