using System;

namespace Power
{
    internal class Power
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            string numberAsString = Console.ReadLine();
            int n = int.Parse(numberAsString);
            Console.Write("m = ");
            numberAsString = Console.ReadLine();
            int m = int.Parse(numberAsString);

            decimal result = 1;

            for (int i = 0; i < m; i++)
            {
                result *= n;
            }

            Console.WriteLine("n^m = " + result);
        }
    }
}