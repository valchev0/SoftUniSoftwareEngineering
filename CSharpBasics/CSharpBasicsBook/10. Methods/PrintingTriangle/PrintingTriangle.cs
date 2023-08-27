using System;

namespace PrintingTriangle
{
    internal class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        private static void PrintTriangle(int n)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(cols + " ");
                }
                Console.WriteLine();
            }
            for (int rows = 1; rows < n; rows++)
            {
                int counter = 1;
                for (int cols = n - rows; cols >= 1; cols--)
                {
                    Console.Write((counter) + " ");
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}