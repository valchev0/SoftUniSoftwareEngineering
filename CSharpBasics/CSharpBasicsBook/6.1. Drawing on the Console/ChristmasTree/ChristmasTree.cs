using System;

namespace ChristmasTree
{
    internal class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row <= n; row++)
            {
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < row; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int i = 0; i < row; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}