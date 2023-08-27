using System;

namespace MathPower
{
    internal class MathPower
    {
        static void Main(string[] args)
        {
            PrintMathPow();
        }

        private static double PrintMathPow()
        {
            double n = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(n, pow));
            return n;
        }
    }
}