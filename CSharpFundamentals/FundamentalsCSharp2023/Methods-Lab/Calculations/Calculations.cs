using System;

namespace Calculations
{
    internal class Calculations
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = 0;
            result = CalculationResult(action, firstNum, secondNum, result);

            Console.WriteLine(result);
        }

        private static int CalculationResult(string action, int firstNum, int secondNum, int result)
        {
            switch (action)
            {
                case "add":
                    result = firstNum + secondNum;
                    break;
                case "multiply":
                    result = firstNum * secondNum;
                    break;
                case "subtract":
                    result = firstNum - secondNum;
                    break;
                case "divide":
                    result = firstNum / secondNum;
                    break;
            }
            return result;
        }
    }
}