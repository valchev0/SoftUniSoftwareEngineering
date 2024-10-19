using System;

namespace ReverseString
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reverse = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }
            Console.WriteLine(reverse);
        }
    }
}