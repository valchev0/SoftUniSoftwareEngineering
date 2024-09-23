using System;
using System.Numerics;

namespace DecimalToHexadecimal
{
    internal class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numCopy = n;
            int diffrence = 0;
            string reversedNumber = string.Empty;
            string hexadecimal = string.Empty;
            while (numCopy > 0)
            {
                diffrence = numCopy % 16;
                numCopy /= 16;
                if (diffrence >= 0 && diffrence < 10)
                {
                    reversedNumber += diffrence;
                }
                else if (diffrence == 10)
                {
                    reversedNumber += "a";
                }
                else if(diffrence == 11)
                {
                    reversedNumber += "b";
                }
                else if(diffrence == 12)
                {
                    reversedNumber += "c";
                }
                else if(diffrence == 13)
                {
                    reversedNumber += "d";
                }
                else if(diffrence == 14)
                {
                    reversedNumber += "e";
                }
                else if(diffrence == 15)
                {
                    reversedNumber += "f";
                }
            }
            for (int i = reversedNumber.Length - 1; i >= 0; i--)
            {
                hexadecimal += reversedNumber[i];
            }
            Console.WriteLine(hexadecimal.ToUpper());
        }
    }
}