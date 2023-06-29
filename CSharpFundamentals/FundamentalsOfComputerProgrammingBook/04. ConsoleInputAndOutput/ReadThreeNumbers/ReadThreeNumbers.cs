using System;
namespace ReadThreeNumbers
{
    internal class ReadThreeNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}\n{1}\n{2}\n", firstNumber, secondNumber, thirdNumber);
        }
    }
}