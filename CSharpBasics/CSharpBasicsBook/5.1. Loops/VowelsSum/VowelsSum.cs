using System;
namespace VowelsSum
{
    internal class VowelsSum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int vowelsSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        vowelsSum++;
                        break;
                    case 'e':
                        vowelsSum += 2;
                        break;
                    case 'i':
                        vowelsSum += 3;
                        break;
                    case 'o':
                        vowelsSum += 4;
                        break;
                    case 'u':
                        vowelsSum += 5;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
                Console.WriteLine(vowelsSum);
            }
        }
    }
}