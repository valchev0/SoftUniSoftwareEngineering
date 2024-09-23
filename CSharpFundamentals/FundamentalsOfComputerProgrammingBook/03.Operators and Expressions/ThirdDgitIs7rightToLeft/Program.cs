using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isTrue = true;
            int num = n;
            int thirdDigit = 0;
            for (int i = 1; i < 3; i++)
            {
                num /= 10;
                thirdDigit = num % 10;
            }
            if (thirdDigit != 7)
            {
                isTrue = false;
            }
            if (isTrue)
            {
                Console.WriteLine("Third digit is 7");
            }
            else
                Console.WriteLine("Third digit is not 7");
        }
    }
}