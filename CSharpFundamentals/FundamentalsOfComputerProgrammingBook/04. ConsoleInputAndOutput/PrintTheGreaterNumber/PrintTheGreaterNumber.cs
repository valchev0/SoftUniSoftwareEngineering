using System;
namespace PrintTheGreaterNumber
{
    internal class PrintTheGreaterNumber
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(firstNum, secondNum));
        }
    }
}