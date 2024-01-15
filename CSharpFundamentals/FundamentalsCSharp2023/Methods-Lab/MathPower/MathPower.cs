using System;

namespace MathPower
{
    internal class MathPower
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double result = MatPower(firstNum, secondNum);
            Console.WriteLine(result);
        }

        private static double MatPower(double firstNum, double secondNum)
        {
            double multiplier = Math.Pow(firstNum, secondNum);
            return multiplier;
        }
    }
}