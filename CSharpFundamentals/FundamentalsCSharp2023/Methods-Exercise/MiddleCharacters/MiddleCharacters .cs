using System;

namespace MiddleCharacters
{
    internal class MiddleCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isEven = LengthIdentifier(input);

            ResultWriteLine(input, isEven);
        }

        static bool LengthIdentifier(string input)
        {
            bool isEven = true;

            if (input.Length % 2 != 0)
            {
                return isEven = false;
            }
            return isEven;
        }

        static void ResultWriteLine(string input, bool isEven)
        {
            int firstMidChar = (input.Length - 1) / 2;

            if (isEven)
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