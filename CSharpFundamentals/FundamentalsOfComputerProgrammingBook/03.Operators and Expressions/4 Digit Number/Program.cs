using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int num = n;
            int sumOfDigits = 0;
            int lastDigit = 0;
            int digit1 = num % 10;
            int digit2 = (num / 10) % 10;
            int digit3 = (num / 100) % 10; 
            int digit4 = (num / 1000) % 10;
            int reversedNumber = int.Parse(string.Concat(digit1, digit2, digit3, digit4));
            int lastAsFirst = int.Parse(string.Concat(digit1, digit4, digit3, digit2));
            int swapSecondAndThird = int.Parse(string.Concat(digit4, digit2, digit3, digit1));
            for (int i = 0; i < 4; i++)
            {
                lastDigit = num % 10;
                num /= 10;
                sumOfDigits += lastDigit;
            }
            Console.WriteLine(sumOfDigits);
            Console.WriteLine(reversedNumber);
            Console.WriteLine(lastAsFirst);
            Console.WriteLine(swapSecondAndThird);

        }
    }
}