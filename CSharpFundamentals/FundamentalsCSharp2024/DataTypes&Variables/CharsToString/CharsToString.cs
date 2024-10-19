using System;

namespace CharsToString
{
    internal class CharsToString
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                char chr = char.Parse(Console.ReadLine());
                str += chr;
            }
            Console.WriteLine(str);

        }
    }
}