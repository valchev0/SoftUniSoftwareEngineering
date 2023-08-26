using System;

namespace ChristmasHat
{
    internal class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopPart(n);
            MidPart(n);
            BottomPart(n);
        }

        private static void BottomPart(int n)
        {
            Console.WriteLine(new string('*', (4 * n) + 1));
            for (int i = 0; i < 4 * n + 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', (4 * n) + 1));
        }

        private static void MidPart(int n)
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write(new string('.', (2 * n) - i));
                Console.Write('*');
                Console.Write(new string('-', i - 1));
                Console.Write('*');
                Console.Write(new string('-', i - 1));
                Console.Write('*');
                Console.Write(new string('.', (2 * n) - i));
                Console.WriteLine();
            }
        }

        private static void TopPart(int n)
        {
            char topOne = '/';
            char mid = '|';
            char topTwo = (char)92;
            string topTop = topOne.ToString() + mid.ToString() + topTwo.ToString();
            string topBottom = topTwo.ToString() + mid.ToString() + topOne.ToString();
            Console.Write(new string('.', (2 * n) - 1));
            Console.Write(topTop);
            Console.Write(new string('.', (2 * n) - 1));
            Console.WriteLine();
            Console.Write(new string('.', (2 * n) - 1));
            Console.Write(topBottom);
            Console.Write(new string('.', (2 * n) - 1));
            Console.WriteLine();
        }
    }
}