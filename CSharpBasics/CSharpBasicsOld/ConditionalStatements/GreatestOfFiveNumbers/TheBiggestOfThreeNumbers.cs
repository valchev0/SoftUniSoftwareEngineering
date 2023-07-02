using System;
namespace TheBiggestOfThreeNumbers
{
    internal class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int firstGreatest = Math.Max(firstNum, secondNum);
            int secondGreatest = Math.Max(firstGreatest, thirdNum);
            
            Console.WriteLine(secondGreatest);
        }
    }
}