using System;

namespace SignOfIntegerNumbers
{
    internal class SignOfIntegerNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string output = string.Empty;
            output = SignInteger(input);
            Console.WriteLine("The number {0} is {1}.", input, output);
        }

        private static string SignInteger(int input)
        {
            string output;
            if (input > 0)
            {
                output = "positive";
            }
            else if (input < 0)
            {
                output = "negative";
            }
            else
            {
                output = "zero";
            }

            return output;
        }
    }
}