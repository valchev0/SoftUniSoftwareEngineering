using System;
namespace AllPossibleCardsFromDeck
{
    internal class AllPossibleCardsFromDeck
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Hearts:");
                }
                else if (i == 2)
                {
                    Console.WriteLine("\nDiamonds:");
                }
                else if (i == 3)
                {
                    Console.WriteLine("\nClubs:");
                }
                else if (i == 4)
                {
                    Console.WriteLine("\nSpades:");
                }
                for (int j = 1; j <= 13; j++)
                {
                    if (j == 1)
                    {
                        Console.Write("A ");
                        continue;
                    }
                    else if (j == 11)
                    {
                        Console.Write("J ");
                        continue;
                    }
                    else if (j == 12)
                    {
                        Console.Write("Q ");
                        continue;
                    }
                    else if (j == 13)
                    {
                        Console.Write("K ");
                        continue;
                    }
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}