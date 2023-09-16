using System;

namespace TriangleOfNumbers
{
    internal class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int index = 0;
            for (int rows = 0; rows <= n; rows++)
            {
                for (int cows = 1; cows <= rows; cows++)
                {
                    Console.Write(index + " ");
                }
                index++;
                Console.WriteLine();
            }
        }
    }
}