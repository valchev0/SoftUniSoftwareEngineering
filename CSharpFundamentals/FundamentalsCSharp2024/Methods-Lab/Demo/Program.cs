using System;
using System.ComponentModel.Design;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char chr = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            switch (chr)
            {
                case '/':
                    Console.WriteLine(DivisionOperation(firstNum, secondNum));
                    break;
                case '*':
                    Console.WriteLine(MultiplyOperation(firstNum, secondNum));
                    break;
                case '+':
                    Console.WriteLine(AddingOperation(firstNum, secondNum));
                    break;
                case '-':
                    Console.WriteLine(SubstractingOperation(firstNum, secondNum));
                    break;
            }
        }
        static double DivisionOperation (double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }

        static double MultiplyOperation (double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        static double AddingOperation (double firstNum, double secondNum)
        { 
            return firstNum + secondNum;
        }

        static double SubstractingOperation (double firstNum, double secondNum)
        { 
            return firstNum - secondNum;
        }
    }
}