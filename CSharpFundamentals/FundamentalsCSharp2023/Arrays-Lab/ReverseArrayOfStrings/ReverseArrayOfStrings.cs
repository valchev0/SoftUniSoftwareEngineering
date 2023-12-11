using System;

namespace ReverseArrayOfStrings
{
    internal class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            arr.Reverse();
            Console.WriteLine(string.Join(' ', arr.Reverse()));
        }
    }
}