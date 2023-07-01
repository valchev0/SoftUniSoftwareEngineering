using System;
namespace ExchangeIfGreater
{
    internal class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                firstNum += secondNum;
                secondNum = firstNum - secondNum;
                firstNum -= secondNum;
            }
            Console.WriteLine(firstNum + " " + secondNum);
        }
    }
}