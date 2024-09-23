using System;
namespace RemainderOfTheirDivisionBy5
{
    internal class RemainderOfTheirDivisionBy5
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}