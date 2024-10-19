using System;

namespace SpecialNumbers
{
    internal class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                int lastDigit = 0;
                int sum = 0;
                while (currentNum > 0)
                {
                    lastDigit = currentNum % 10;
                    sum += lastDigit;
                    currentNum /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
    }
}