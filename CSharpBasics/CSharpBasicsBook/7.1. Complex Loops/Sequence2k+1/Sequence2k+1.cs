using System;

namespace Sequence2kPlus1
{
    internal class Sequence2kPlus1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            while (num <= n)
            {
                Console.WriteLine(num);
                num = (2 * num) + 1;
            }
        }
    }
}