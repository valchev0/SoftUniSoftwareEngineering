using System;

namespace FactorialDivision
{
    internal class FactorialDivision
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{FactorialDivisionResult(firstNum, secondNum):f2}");
        }
        static decimal FactorialDivisionResult (int firstNum, int secondNum)
        {

            decimal firstFactorial = 1;
            for (int i = 1; i <= firstNum; i++)
            {
                firstFactorial *= i;
            }

            decimal secondFactorial = 1;
            for(int i = 1; i <= secondNum; i++)
            {
                secondFactorial *= i;
            }

            decimal result = firstFactorial / secondFactorial;
            return result;
        }
    }
}