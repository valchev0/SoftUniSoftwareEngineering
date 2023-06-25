using System;
using System.ComponentModel;
using System.Numerics;
using System.Xml.Linq;

class NumeralSystemConversions
{
    static void Main(string[] args)
    {
        string inputNumSystem = Console.ReadLine().ToLower();   //bin, dec, hex
        string input = Console.ReadLine().ToLower();
        int inputNumber = int.Parse(input);

        string outputNumSystem = Console.ReadLine().ToLower(); 

        string inputBinary = null;
        //decimal to binary


        if (inputNumSystem == "dec" || inputNumSystem == "decimal")    //converter
        {
            DecimalToBinary(inputNumber);
        }
        else if (inputNumSystem == "hex" || inputNumSystem == "heximal")
        {
            inputBinary = HeximalToBinary(input);
        }
        else if (inputNumSystem == "bin" || inputNumSystem == "binary")
        {
            string binary = BinaryToBinary(input);
        }

        if (outputNumSystem == "bin" || outputNumSystem == "binary")
        {
            
        }

        //char[] array = Console.ReadLine().;
        //int currentNumber = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    currentNumber = Convert.ToInt32(array[i]);
        //    Console.WriteLine(currentNumber);
        //}
        //BinaryToDecimal(input);




    }

    private static string BinaryToBinary(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string binary = new string(charArray);
        if (binary.Length % 2 != 0)
        {
            binary += 0;
        }
        if (binary.Length % 4 != 0)
        {
            binary += 0;
        }
        if (binary.Length % 8 != 0)
        {
            binary += 0;
        }
        if (binary.Length < 8)
        {
            if (binary.Length % 8 != 0)
            {
                binary += 0;
            }
            if (binary.Length < 8)
            {
                if (binary.Length % 8 != 0)
                {
                    binary += 0;
                }
            }
            if (binary.Length < 8)
            {
                if (binary.Length % 8 != 0)
                {
                    binary += 0;
                }
            }
            if (binary.Length < 8)
            {
                if (binary.Length % 8 != 0)
                {
                    binary += 0;
                }
            }
        }
        char[] array = binary.ToCharArray();
        Array.Reverse(array);
        binary = new string(array);
        return binary;
    }

    private static void BinaryToDecimal(string input)
    {
        int currentNum = 0;
        int binDec = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '1')
            {
                currentNum = (int)Math.Pow(2, (input.Length - (i + 1)));
            }
            binDec += currentNum;
            currentNum = 0;
        }
        Console.WriteLine(binDec);
    }

    private static string HeximalToBinary(string input)
    {
        string inputBinary;
        string bin = null;
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string hex = new string(charArray);
        char? currentChar = null;

        string binary = null;

        for (int i = 0; i < input.Length; i++)
        {
            currentChar = input[i];
            switch (currentChar)
            {
                case '0':
                    bin += "0000";
                    break;
                case '1':
                    bin += "0001";
                    break;
                case '2':
                    bin += "0010";
                    break;
                case '3':
                    bin += "0011";
                    break;
                case '4':
                    bin += "0100";
                    break;
                case '5':
                    bin += "0101";
                    break;
                case '6':
                    bin += "0110";
                    break;
                case '7':
                    bin += "0111";
                    break;
                case '8':
                    bin += "1000";
                    break;
                case '9':
                    bin += "1001";
                    break;
                case 'a':
                    bin += "1010";
                    break;
                case 'b':
                    bin += "1011";
                    break;
                case 'c':
                    bin += "1100";
                    break;
                case 'd':
                    bin += "1101";
                    break;
                case 'e':
                    bin += "1110";
                    break;
                case 'f':
                    bin += "1111";
                    break;
            }
        }
        inputBinary = bin;
        Console.WriteLine(inputBinary);
        return inputBinary;
    }

    private static void DecimalToBinary(int inputNumber)
    {
        int num = inputNumber;
        int numCopy = num;
        int indicator = 0;
        int digit = 0;
        string container = string.Empty;
        while (true)
        {
            for (int i = 0; i < 1; i++)
            {
                digit = num % 2;
                num /= 2;
            }
            container += digit;
            if (num <= 0)
            {
                if (container.Length % 2 != 0)
                {
                    container += 0;
                }
                if (container.Length % 4 != 0)
                {
                    container += 0;
                }
                if (container.Length % 8 != 0)
                {
                    container += 0;
                }
                if (container.Length < 8)
                {
                    if (container.Length % 8 != 0)
                    {
                        container += 0;
                    }
                    if (container.Length < 8)
                    {
                        if (container.Length % 8 != 0)
                        {
                            container += 0;
                        }
                    }
                    if (container.Length < 8)
                    {
                        if (container.Length % 8 != 0)
                        {
                            container += 0;
                        }
                    }
                    if (container.Length < 8)
                    {
                        if (container.Length % 8 != 0)
                        {
                            container += 0;
                        }
                    }
                }
                char[] charArray = container.ToCharArray();
                Array.Reverse(charArray);
                string binary = new string(charArray);
                Console.WriteLine(binary);
                break;
            }
        }
    }
}