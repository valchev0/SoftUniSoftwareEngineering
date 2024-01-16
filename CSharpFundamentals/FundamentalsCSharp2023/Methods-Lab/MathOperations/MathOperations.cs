using System;

namespace MathOperations
{
    internal class MathOperations
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char calcOperator = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = 0;

            result = OpeationsResult(calcOperator, result, firstNum, secondNum);

            Console.Write(result);

            int OpeationsResult(char c, int d, int i, int secondNum1)
            {
                switch (c)
                {
                    case '/':
                        d = i / secondNum1;
                        break;
                    case '*':
                        d = i * secondNum1;
                        break;
                    case '+':
                        d = i + secondNum1;
                        break;
                    case '-':
                        d = i - secondNum1;
                        break;
                }

                return d;
            }
        }
    }
}