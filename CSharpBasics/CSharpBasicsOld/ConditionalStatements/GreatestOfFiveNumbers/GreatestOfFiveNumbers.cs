using System;
namespace GreatestOfFiveNumbers
{
    internal class GreatestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            double fourthNum = double.Parse(Console.ReadLine());
            double fifthNum = double.Parse(Console.ReadLine());

            double firstGreatest = Math.Max(fifthNum, secondNum);
            double secondGreatest = Math.Max(firstGreatest, thirdNum);
            double thirdGreatest = Math.Max(secondGreatest, fourthNum);
            Console.WriteLine(Math.Max(thirdGreatest, fifthNum));
        }
    }
}