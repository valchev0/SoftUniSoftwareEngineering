using System;
namespace GreatestOfFiveNumbers
{
    internal class GreatestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            int fifthNum = int.Parse(Console.ReadLine());

            int firstGreatest = Math.Max(fifthNum, secondNum);
            int secondGreatest = Math.Max(firstGreatest, thirdNum);
            int thirdGreatest = Math.Max(secondGreatest, fourthNum);
            Console.WriteLine(Math.Max(thirdGreatest, fifthNum));
        }
    }
}