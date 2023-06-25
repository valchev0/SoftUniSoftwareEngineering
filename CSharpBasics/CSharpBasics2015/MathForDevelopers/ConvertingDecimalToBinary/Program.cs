using System;

class ConvertingDecimalToBinary
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
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
                char[] charArray = container.ToCharArray();
                Array.Reverse(charArray);
                string binary = new string(charArray);
                Console.WriteLine(binary);
                break;
            }
        }
    }
}
