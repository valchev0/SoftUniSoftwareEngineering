using System;

namespace DigitToString
{
    internal class DigitToString
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(ConvertToString(n));
        }
        static string ConvertToString(int n)
        {
            int lastDigit = n % 10;
            string result = string.Empty;

            switch (lastDigit)
            {
                case 0:
                    result = "Zero";
                    break;
                case 1:
                    result = "One";
                    break;
                case 2:
                    result = "Two";
                    break;
                case 3:
                    result = "Three";
                    break;
                case 4:
                    result = "Four";
                    break;
                case 5:
                    result = "Five";
                    break;
                case 6:
                    result = "Six";
                    break;
                case 7:
                    result = "Seven";
                    break;
                case '8':
                    result = "Eight";
                    break;
                case 9:
                    result = "Nine";
                    break;
            }
            return result;
        }
    }
}
