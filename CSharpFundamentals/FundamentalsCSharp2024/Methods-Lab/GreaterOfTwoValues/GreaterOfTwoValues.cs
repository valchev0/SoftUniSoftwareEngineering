using System;

namespace GreaterOfTwoValues
{
    internal class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    int greaterInt = GetMaxInt(firstInt, secondInt);
                    Console.WriteLine(greaterInt);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char greaterChar = GetMaxChar(firstChar, secondChar);
                    Console.WriteLine(greaterChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string greaterString = GetMaxString(firstString, secondString, out var result);
                    Console.WriteLine(greaterString);
                    break;
            }

            int GetMaxInt(int a, int b)
            {
                if (a > b)
                {
                    return a;
                }

                return b;
            }

            char GetMaxChar(char a, char b)
            {
                if (a > b)
                {
                    return a;
                }
                return b;
            }

            string GetMaxString(string? a, string? b, out int result)
            {
                result = a.CompareTo(b);
                if (result > 0)
                {
                    return a;
                }

                return b;
            }
        }
    }
}