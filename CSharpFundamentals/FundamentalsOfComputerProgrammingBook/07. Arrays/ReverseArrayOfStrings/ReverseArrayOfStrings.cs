using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    internal class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            //string[] arr = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Reverse()
            //    .ToArray();

            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr.Length / 2; i++)
            {
                var temp = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}