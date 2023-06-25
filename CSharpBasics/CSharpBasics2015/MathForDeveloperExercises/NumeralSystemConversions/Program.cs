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
        string binary = null;

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
            binary = BinaryToBinary(input);
        }
        binary = BinaryToBinary(input);

        if (outputNumSystem == "bin" || outputNumSystem == "binary")
        {
            string binaryOutput = binary;
            Console.WriteLine(binaryOutput);
        }
        else if (outputNumSystem == "dec" || outputNumSystem == "decimal")
        {
            BinaryToDecimal(binary);
        }
        else if (outputNumSystem == "hex" || outputNumSystem == "heximal")
        {
            BinaryToHeximal(binary);
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

    private static void BinaryToHeximal(string binary)
    {
        string heximalOutput = null;
        string currentString = null;
        for (int i = 0; i < binary.Length; i++)
        {
            currentString += binary[i];
            if (currentString.Length == 4)
            {
                switch (currentString)
                {
                    case "0000":
                        break;
                    case "0001":
                        heximalOutput += 1;
                        break;
                    case "0010":
                        heximalOutput += 2;
                        break;
                    case "0011":
                        heximalOutput += 3;
                        break;
                    case "0100":
                        heximalOutput += 4;
                        break;
                    case "0101":
                        heximalOutput += 5;
                        break;
                    case "0110":
                        heximalOutput += 6;
                        break;
                    case "0111":
                        heximalOutput += 7;
                        break;
                    case "1000":
                        heximalOutput += 8;
                        break;
                    case "1001":
                        heximalOutput += 9;
                        break;
                    case "1010":
                        heximalOutput += 'A';
                        break;
                    case "1011":
                        heximalOutput += 'B';
                        break;
                    case "1100":
                        heximalOutput += 'C';
                        break;
                    case "1101":
                        heximalOutput += 'D';
                        break;
                    case "1110":
                        heximalOutput += 'E';
                        break;
                    case "1111":
                        heximalOutput += 'F';
                        break;
                }
                currentString = null;
            }
        }
        Console.WriteLine(heximalOutput);
    }

    private static void BinaryToDecimal(string binary)
    {
        int decimalNum = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                decimalNum += 1 * ((int)Math.Pow(2, (binary.Length - (i + 1))));
            }
        }
        Console.WriteLine(decimalNum);
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

    //private static void BinaryToDecimal(string input)
    //{
    //    int currentNum = 0;
    //    int binDec = 0;
    //    for (int i = 0; i < input.Length; i++)
    //    {
    //        if (input[i] == '1')
    //        {
    //            currentNum = (int)Math.Pow(2, (input.Length - (i + 1)));
    //        }
    //        binDec += currentNum;
    //        currentNum = 0;
    //    }
    //    Console.WriteLine(binDec);
    //}

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