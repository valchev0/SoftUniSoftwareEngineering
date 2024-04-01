using System;

namespace AddAndSubtract
{
    internal class AddAndSubtract
    {
        static void Main(string[] args)
        {
            int sum = SumMethod();

            Console.WriteLine(SubstractMethod(sum));
        }

        static int SumMethod()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            return firstNum + secondNum; 
        }

        static int SubstractMethod(int sum)
        {
            int thirdSum = int.Parse(Console.ReadLine());

            return sum - thirdSum;
        }
    }
}