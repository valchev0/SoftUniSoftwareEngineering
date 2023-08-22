using System;

namespace SumsThreeNumbers
{
    internal class SumsThreeNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int min = Math.Min(thirdNum, Math.Min(firstNum, secondNum));
            int max = Math.Max(thirdNum, Math.Max(firstNum, secondNum));
            int diffrence = max - min;

            if (diffrence == firstNum || diffrence == secondNum || diffrence == thirdNum)
            {
                Console.WriteLine("{0} + {1} = {2}", min, diffrence, max);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}