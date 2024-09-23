using System;

namespace MaxOfThreeNumbers
{
    internal class MaxOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GetMax(a, b, c);
        }

        private static void GetMax(int a, int b, int c)
        {
            int result = Math.Max(a, Math.Max(b, c));
            Console.WriteLine(result);
        }
    }
}
