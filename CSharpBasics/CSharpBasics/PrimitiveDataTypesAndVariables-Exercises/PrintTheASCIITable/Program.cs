using System;

class PrintTheASCIITable
{
    static void Main()
    {
        for (int i = 0; i <= 255; i++)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write((char)i + " ");
        }
    }
}