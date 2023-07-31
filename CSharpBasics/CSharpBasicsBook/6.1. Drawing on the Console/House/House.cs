using System;

namespace House
{
    internal class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Roof(n);
            Fundament(n);
        }

        private static void Fundament(int n)
        {
            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }

        private static void Roof(int n)
        {
            for (int row = 0; row < (n + 1) / 2; row++)
            {
                int helper = 1;
                if (n % 2 == 0)
                {
                    helper = 2;
                }
                for (int col = helper; col <= n / 2 - row; col += 1)
                {
                    Console.Write("-");
                }
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("*");
                }
                if (n % 2 == 1)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int col = 0; col <= row; col++)
                    {
                        Console.Write("*");
                    }
                }
                for (int col = helper; col <= n / 2 - row; col += 1)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }
    }
}