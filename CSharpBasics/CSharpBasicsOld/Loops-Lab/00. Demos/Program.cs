using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            for (int row = 0; row <= n; row++)
            {
                int spacesCount = (n - row);
                string spaces = new string(' ', spacesCount);
                Console.Write(spaces);
                for (int col = 2; col <= row; col++)
                {
                    Console.Write("*");
                    if (col < row)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}