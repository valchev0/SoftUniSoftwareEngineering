using System;
namespace PlusMinusSum
{
    internal class PlusMinusSum
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = firstNum + secondNum + thirdNum;

            if (sum > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
            

        }
    }
}