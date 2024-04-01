using System;

namespace MiddleCharacters
{
    internal class MiddleCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            ResultWriteLine(input);
        }
        static void ResultWriteLine(string input)
        {
            int firstMidChar = (input.Length - 1) / 2;

            if (input.Length % 2 == 0)
            {
                int secondMidChar = input.Length / 2;

                Console.WriteLine($"{input[firstMidChar]}{input[secondMidChar]}");
                return;
            }
            else
            {
                Console.WriteLine($"{input[firstMidChar]}");
                return;
            }
        }
    }
}