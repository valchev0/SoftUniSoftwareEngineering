using System;
namespace GreatestOfFiveIntegers
{
    internal class GreatestOfFiveIntegers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            int fifthNum = int.Parse(Console.ReadLine());
            int firstGreatNum = Math.Max(firstNum, secondNum);
            int secondGreatNum = Math.Max(firstGreatNum, thirdNum);
            int thirdGreatNum = Math.Max(secondGreatNum, fourthNum);
            int fifthGreatNum = Math.Max(thirdGreatNum, fifthNum);

            Console.WriteLine(fifthGreatNum);
        }
    }
}