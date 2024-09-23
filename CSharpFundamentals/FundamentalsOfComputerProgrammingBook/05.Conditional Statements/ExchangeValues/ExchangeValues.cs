using System;
namespace ExchangeValues
{
    internal class ExchangeValues
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum < secondNum)
            {
                Console.WriteLine("Exchanges");
                firstNum = secondNum;
                Console.WriteLine("Now the first number is = " + firstNum);
            }
            else
            {
                Console.WriteLine("First number is bigger");
            }

        }
    }
}