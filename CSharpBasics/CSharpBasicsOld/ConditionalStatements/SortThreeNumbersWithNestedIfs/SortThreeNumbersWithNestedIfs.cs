using System;
namespace SortThreeNumbersWithNestedIfs
{
    internal class SortThreeNumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (firstNum >= secondNum && firstNum >= thirdNum)
            {
                Console.Write(firstNum + " ");
                if (secondNum >= thirdNum)
                {
                    Console.Write(secondNum + " ");
                    Console.Write(thirdNum);
                }
                else
                {
                    Console.Write(thirdNum + " ");
                    Console.Write(secondNum);
                }
            }
            else if (secondNum >= firstNum && secondNum >= thirdNum)
            {
                Console.Write(secondNum + " ");
                if (firstNum >= thirdNum)
                {
                    Console.Write(firstNum + " ");
                    Console.Write(thirdNum);
                }
                else
                {
                    Console.Write(thirdNum + " ");
                    Console.Write(firstNum);
                }
            }
            else
            {
                Console.Write(thirdNum + " ");
                if (secondNum >= firstNum)
                {
                    Console.Write(secondNum + " ");
                    Console.Write(firstNum);
                }
                else
                {
                    Console.Write(firstNum + " ");
                    Console.Write(secondNum);
                }
            }
        }
    }
}