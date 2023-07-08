using System;
namespace LatinLetters
{
    internal class LatinLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latin alphabet:");
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                    Console.WriteLine(" " + letter);
            }
            Console.WriteLine();
        }
    }
}