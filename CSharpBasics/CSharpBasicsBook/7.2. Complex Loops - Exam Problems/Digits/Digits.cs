using System;

namespace Digits
{
    internal class Digits
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var firstDigit = number / 100;
            var secondDigit = (number % 100) / 10;
            var thirdDigit = number % 10;
            var rows = firstDigit + secondDigit;
            var cols = firstDigit + thirdDigit;

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    if (number % 5 == 0)
                    {
                        number -= firstDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= secondDigit;
                    }
                    else
                    {
                        number += thirdDigit;
                    }
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }

        }
    }
}