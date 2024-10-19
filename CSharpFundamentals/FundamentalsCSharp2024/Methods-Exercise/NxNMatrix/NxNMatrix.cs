using System;

namespace NxNMatrix
{
    internal class NxNMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);
        }

        static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (j < n - 1)
                    {
                        Console.Write($"{n} ");
                    }
                    if (j == n - 1)
                    {
                        Console.Write(n);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}