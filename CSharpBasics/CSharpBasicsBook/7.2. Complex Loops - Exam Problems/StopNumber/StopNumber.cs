using System;

namespace StopNumber
{
    internal class StopNumber
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());

            for (int i = secondNum; i >= firstNum; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == stopNumber)
                    {
                        break;
                    }
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}