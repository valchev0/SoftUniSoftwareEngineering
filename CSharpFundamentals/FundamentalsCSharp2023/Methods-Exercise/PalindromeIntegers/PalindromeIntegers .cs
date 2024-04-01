using System;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            PolidromeIdentifier(input);
        }
        
        static string PolidromeIdentifier (string input)
        {
            while ((input = Console.ReadLine()) != "END")
            {
                if (input[0] == input[input.Length - 1])
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            return input;
        }
    }
}