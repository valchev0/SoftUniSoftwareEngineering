using System;

namespace ReverseArrayOfStrings
{
    internal class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse()));
        }
    }
}