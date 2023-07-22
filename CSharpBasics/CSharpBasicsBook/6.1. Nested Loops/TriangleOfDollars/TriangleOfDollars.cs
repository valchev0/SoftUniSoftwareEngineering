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
                Console.Write("$");
                for (int cols = 0; cols < rows; cols++)
                {
                    Console.Write(" $");
                    //if (cols != (n - 1))
                    //{
                    //    Console.Write(" ");
                    //}
                }
                Console.WriteLine();
            }
        }
    }
}