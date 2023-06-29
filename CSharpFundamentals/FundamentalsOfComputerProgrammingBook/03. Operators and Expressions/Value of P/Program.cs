using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 35; // 0010 0011
            int p = 5;
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine(bit); // Output: 1

            p = 6;
            mask = 1 << p;
            nAndMask = n & mask;
            bit = nAndMask >> p;
            Console.WriteLine(bit); // Output: 0
        }
    }
}