using System;

namespace MatrixOfN
{
    internal class MatrixOfN
    {
        static void Main(string[] args)
        {
            //not completed
            int n = int.Parse(Console.ReadLine());
            int stopper = 0;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = rows; columns <= n + stopper; columns++)
                {
                    Console.Write(columns + " ");
                }
                Console.WriteLine();
                stopper++;
            }
        }
    }
}