using System;

namespace BinaryToHexadecimal
{
    internal class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            string hexadecimal = string.Empty;
            string container = string.Empty;
            for (int i = 0; i < binary.Length; i++)
            {
                container += binary[i];
                if (container.Length == 4)
                {
                    switch (container)
                    {
                        case "0000":
                            break;
                        case "0001":
                            hexadecimal += 1;
                            break;
                        case "0010":
                            hexadecimal += 2;
                            break;
                        case "0011":
                            hexadecimal += 3;
                            break;
                        case "0100":
                            hexadecimal += 4;
                            break;
                        case "0101":
                            hexadecimal += 5;
                            break;
                        case "0110":
                            hexadecimal += 6;
                            break;
                        case "0111":
                            hexadecimal += 7;
                            break;
                        case "1000":
                            hexadecimal += 8;
                            break;
                        case "1001":
                            hexadecimal += 9;
                            break;
                        case "1010":
                            hexadecimal += 'A';
                            break;
                        case "1011":
                            hexadecimal += 'B';
                            break;
                        case "1100":
                            hexadecimal += 'C';
                            break;
                        case "1101":
                            hexadecimal += 'D';
                            break;
                        case "1110":
                            hexadecimal += 'E';
                            break;
                        case "1111":
                            hexadecimal += 'F';
                            break;
                    }
                    container = string.Empty;
                }
            }
            Console.WriteLine(hexadecimal);
        }
    }
}