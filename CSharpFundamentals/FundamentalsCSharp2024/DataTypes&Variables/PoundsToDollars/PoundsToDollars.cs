using System;

namespace PoundsToDollars
{
    internal class PoundsToDollars
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            decimal output = input * 1.31m;
            Console.WriteLine("{0:0.000}", output);
        }
    }
}