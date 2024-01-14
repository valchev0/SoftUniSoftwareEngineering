using System;

namespace PrintingTriangle
{
    internal class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Up(n);
            Down(n);
        }

        private static void Down(int n)
        {
            for (int column = n - 1; column > 0; column--)
            {
                for (int row = 1; row <= column; row++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Up(int n)
        {
            for (int column = 1; column <= n; column++)
            {
                for (int row = 1; row <= column; row++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}