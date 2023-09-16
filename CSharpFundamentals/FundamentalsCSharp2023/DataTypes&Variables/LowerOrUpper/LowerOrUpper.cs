using System;

namespace LowerOrUpper
{
    internal class LowerOrUpper
    {
        static void Main(string[] args)
        {
            char input = Console.ReadLine()[0];
            if (char.IsUpper(input))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}