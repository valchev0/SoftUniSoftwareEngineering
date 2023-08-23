using System;

namespace PerfectDiamond
{
    internal class PerfectDiamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {

                Console.Write(new string(' ', ((n - rows))));
                Console.Write("*");
                if (rows > 0)
                {
                    for (int cols = 1; cols < rows; cols++)
                    {
                        Console.Write("-*");
                    }
                }
                Console.WriteLine();
            }
            for (int rows = n - 1; rows > 0; rows--)
            {
                Console.Write(new string(' ', ((n - rows))));

                Console.Write("*");
                if (rows > 0)
                {
                    for (int cols = 1; cols < rows; cols++)
                    {
                        Console.Write("-*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}