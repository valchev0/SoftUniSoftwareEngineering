using System;

namespace TriplesOfLatinLetters
{
    internal class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i <= 'c'; i++)
            {
                for ( char j = 'a'; j <= 'c'; j++)
                {
                    for(char k = 'a'; k <= 'c'; k++)
                    {

                        Console.WriteLine("{0}{1}{2}", i, j, k);
                    }
                }
            }
        }
    }
}