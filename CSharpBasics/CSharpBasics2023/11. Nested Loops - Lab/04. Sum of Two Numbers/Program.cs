using System;
using System.Runtime.ExceptionServices;

namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int validCombinations = 0;
            bool isFound = false;
            for (int i = from; i <= to; i++)
            {
                for (int k = from; k <= to; k++)
                {
                    validCombinations++;
                    if (i + k == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{validCombinations} ({i} + {k} = {magicNumber})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound) { break; }
            }
            if (!isFound) { Console.WriteLine($"{validCombinations} combinations - neither equals {magicNumber}"); }

            ////OR
            //int from = int.Parse(Console.ReadLine());
            //int to = int.Parse(Console.ReadLine());
            //int magicNumber = int.Parse(Console.ReadLine());
            //bool isFound = false;
            //int combinations = 0;
            //int firstNum = -1;
            //int secondNum  = -1;
            //for (int x1 = from; x1 <= to; x1++)
            //{
            //    for (int x2 = from; x2 <= to; x2++)
            //    {
            //            combinations++;
            //            if (x1 + x2 == magicNumber) 
            //            { 
            //            isFound = true; 
            //            firstNum= x1;
            //            secondNum= x2;
            //            break; 
            //            }
            //    }
            //    if (isFound)
            //    {
            //        break;
            //    }
            //}
            //if (isFound)
            //{
            //    Console.WriteLine($"Combination N:{combinations} ({firstNum} + {secondNum} = {magicNumber})");
            //}
            //else { Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}"); }
        }
    }
}