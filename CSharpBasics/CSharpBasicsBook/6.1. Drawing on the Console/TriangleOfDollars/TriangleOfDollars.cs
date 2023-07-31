using System;

namespace TriangleOfDollars
{
    internal class TriangleOfDollars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (cols == 0 || cols == n - 1)
                    {
                        if (rows != 0 && rows != n - 1)
                        {
                            Console.Write("| ");
                        }
                        else
                        {
                            Console.Write("+ ");
                        }
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}