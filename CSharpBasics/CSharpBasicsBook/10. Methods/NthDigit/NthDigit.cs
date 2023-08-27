using System;

namespace NthDigit
{
    internal class NthDigit
    {
        static void Main(string[] args)
        {
            DigitFinder();
        }

        private static void DigitFinder()
        {
            string number = Console.ReadLine();
            string oposite = string.Empty;
            int digit = int.Parse(Console.ReadLine());

            for (int i = number.Length - 1; i >= 0; i--)
            {
                oposite += number[i];
            }
            for (int i = 0; i < oposite.Length; i++)
            {
                if (digit - 1 == i)
                {
                    Console.WriteLine(oposite[i]);
                }
            }
        }
    }
}