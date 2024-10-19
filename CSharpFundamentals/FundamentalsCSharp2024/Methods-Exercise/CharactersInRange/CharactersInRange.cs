using System;

namespace CharactersInRange
{
    internal class CharactersInRange
    {
        static void Main(string[] args)
        {
            char charStart = char.Parse(Console.ReadLine());
            char charEnd = char.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", (CharactersArray(charStart, charEnd))));
        }

        static char[] CharactersArray(char charStart, char charEnd)
        {
            int length = Math.Abs(charStart.CompareTo(charEnd));
            char[] chars = new char[length];

            int start = (int)charStart + 1;
            int end = (int)charEnd;
            int counter = 0;

            for (int i = start; i < end; i++)
            {
                chars[counter] = (char)i;
                counter++;
            }

            return chars;
        }
    }
}