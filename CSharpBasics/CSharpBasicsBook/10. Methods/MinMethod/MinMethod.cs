using System;

namespace MinMethod
{
    internal class MinMethod
    {
        static void Main(string[] args)
        {
            GetMin();
        }

        private static void GetMin()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine((Math.Min(Math.Min(a, b), c)));
        }
    }
}