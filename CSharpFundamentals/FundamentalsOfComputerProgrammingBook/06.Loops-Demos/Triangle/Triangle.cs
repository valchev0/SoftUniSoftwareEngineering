using System;

namespace Triangle
{
    internal class Triangle
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            string consoleInput = Console.ReadLine();
            int n = int.Parse(consoleInput);
            Console.WriteLine();

            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write("{0} ", column);
                }
                Console.WriteLine();
            }
        }
    }
}