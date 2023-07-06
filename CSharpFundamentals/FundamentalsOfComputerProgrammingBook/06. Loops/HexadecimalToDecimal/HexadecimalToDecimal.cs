using System;
using System.Numerics;

namespace HexadecimalToDecimal
{
    internal class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine().ToLower();
            char element = ' ';
            int decimalNum = 0;
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                element = hexadecimal[i];
                switch (element)
                {
                    case '0':
                        decimalNum += 0;
                        break;
                    case '1':
                        decimalNum += 1 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1))); 
                        break;
                    case '2':
                        decimalNum += 2 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case '3':
                        decimalNum += 3 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case '4':
                        decimalNum += 4 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case '5':
                        decimalNum += 5 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case '6':
                        decimalNum += 6 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case '7':
                        decimalNum += 7 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case '8':
                        decimalNum += 8 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case '9':
                        decimalNum += 9 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case 'a':
                        decimalNum += 10 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case 'b':
                        decimalNum += 11 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case 'c':
                        decimalNum += 12 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case 'd':
                        decimalNum += 13 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case 'e':
                        decimalNum += 14 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                    case 'f':
                        decimalNum += 15 * (int)Math.Pow(16, (hexadecimal.Length - (i + 1)));
                        break;
                }
            }
            Console.WriteLine(decimalNum);
        }
    }
}