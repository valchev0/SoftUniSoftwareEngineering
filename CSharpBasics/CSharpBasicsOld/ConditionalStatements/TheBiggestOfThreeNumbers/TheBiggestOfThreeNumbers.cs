using System;
namespace TheBiggestOfThreeNumbers
{
    internal class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double firstGreatest = Math.Max(firstNum, secondNum);
            Console.WriteLine(Math.Max(firstGreatest, thirdNum));
        }
    }
}