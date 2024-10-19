using System;

namespace ReversedChars
{
    internal class ReversedChars
    {
        static void Main(string[] args)
        {
            char chr = ' ';
            string str = string.Empty;
            string reverse = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                chr = char.Parse(Console.ReadLine());
                str += ' ';
                str += chr;
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine("{0}", reverse);
        }
    }
}