using System;

namespace Rectangle
{
    internal class Rectangle
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}