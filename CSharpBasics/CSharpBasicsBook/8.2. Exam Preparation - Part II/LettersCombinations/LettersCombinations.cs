using System;

namespace LettersCombinations
{
    internal class LettersCombinations
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char pass = char.Parse(Console.ReadLine());
            char lastChar = first;
            int counter = 0;

            for (int j = first; j <= end; j++)
            {
                if (j == pass)
                {
                    continue;
                }
                for (int k = first; k <= end; k++)
                {
                    if (k == pass)
                    {
                        continue;
                    }
                    for (int l = lastChar; l <= end; l++)
                    {
                        if (l == pass)
                        {
                            continue;
                        }
                        Console.Write("{0}{1}{2} ", (char)j, (char)k, (char)l);
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}