using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {
        int decimalNum = int.Parse(Console.ReadLine());
        int temporaryNum = 0;
        string temporaryString = null;
        string heximal = null;
        while (decimalNum > 0)
        {
            temporaryNum = decimalNum % 16;
            decimalNum /= 16;
            switch (temporaryNum)
            {
                case 0:
                    temporaryString += 0;
                    break;
                case 1:
                    temporaryString += 1; 
                    break;
                case 2:
                    temporaryString += 2;
                    break;
                case 3:
                    temporaryString += 3;
                    break;
                case 4:
                    temporaryString += 4;
                    break;
                case 5:
                    temporaryString += 5;
                    break;
                case 6:
                    temporaryString += 6;
                    break;
                case 7:
                    temporaryString += 7;
                    break;
                case 8:
                    temporaryString += 8;
                    break;
                case 9:
                    temporaryString += 9;
                    break;
                case 10:
                    temporaryString += "A";
                    break;
                case 11:
                    temporaryString += "B";
                    break;
                case 12:
                    temporaryString += "C";
                    break;
                case 13:
                    temporaryString += "D";
                    break;
                case 14:
                    temporaryString += "E";
                    break;
                case 15:
                    temporaryString += "F";
                    break;
            }
        }
        for (int i = temporaryString.Length - 1; i >= 0; i--)
        {
            heximal += temporaryString[i];
        }
        Console.WriteLine(heximal);
    }
}