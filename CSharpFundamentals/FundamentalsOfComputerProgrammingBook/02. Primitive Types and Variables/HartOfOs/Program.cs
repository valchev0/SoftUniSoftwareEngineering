using System;
using System.Formats.Asn1;

class MyConsoleApp
{
    static void Main()
    {
        for (int row = 0; row <= 2; row++)
        {
            for (int col = 1; col <= 17; col++)
            {
                if ((col >= 3 - row && col <= 6 + row) || (col >= 12 - row && col <= 15 + row))
                {
                    Console.Write("o");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        for (int row = 0; row < 9; row++)
        {
            for(int col = 1;col <= 17; col++)
            {
                if (col >= row + 1 && col <= 17 - row)
                {
                    Console.Write("o");
                }
                else 
                {
                    Console.Write(" "); 
                }
            }
            Console.WriteLine();
        }
    }
}
