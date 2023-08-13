using System;

namespace NumberTable
{
    internal class NumberTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int row = 0; row < n; row ++)
            {
                for (int col = 0; col <= n; col++)
                {
                    num = row + col;
                    if (num >= n)
                    {
                        num = -num + 2 * n;

                    }
                    if (col > 0)
                    {   
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}