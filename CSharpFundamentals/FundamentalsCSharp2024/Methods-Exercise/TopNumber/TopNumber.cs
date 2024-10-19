using System;

namespace TopNumber
{
    internal class TopNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string temp = string.Empty;

            for (int i = 0; i <= n; i++)
            {
                temp = i.ToString();
                if (SumOfDigitsIsDivisibleByEight(i) == true)
                {
                    if (AtLeastOneOddDigit(temp) == true)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        static bool SumOfDigitsIsDivisibleByEight(int i)
        {
            int sum = 0;
            int lastDigit = 0;

            while (i > 0)
            {
                lastDigit = i % 10;
                sum += lastDigit;
                i /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool AtLeastOneOddDigit(string temp)
        {
            for (int j = 0; j < temp.Length; j++)
            {
                int temp = (int)temp[j];

                if (temp % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}