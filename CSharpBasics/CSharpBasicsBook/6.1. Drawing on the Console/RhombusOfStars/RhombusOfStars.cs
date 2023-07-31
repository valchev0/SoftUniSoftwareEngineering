using System;

namespace RhombusOfStars
{
    internal class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Top(n);
            Bottom(n);
        }

        private static void Bottom(int n)
        {
            for (int row = n - 1; row >= 1; row--)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

        private static void Top(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}