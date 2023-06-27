using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int leftFrame = 0; leftFrame < 2 * n; leftFrame++)
            {
                if (row == 0 || row == n - 1)
                {
                    Console.Write("*");
                }
                //int spaces = ((2 * n) - 1) - row - 1;
                else if (leftFrame == 0 || leftFrame == ((2 * n) - 1))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("/");
                }
            }
            for (int bridge = 0; bridge < n; bridge++)
            {
                if (row == n/2)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            for (int rightFrame = 0; rightFrame < 2 * n; rightFrame++)
            {
                if (row == 0 || row == n - 1)
                {
                    Console.Write("*");
                }
                //int spaces = ((2 * n) - 1) - row - 1;
                else if (rightFrame == 0 || rightFrame == ((2 * n) - 1))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("/");
                }
            }
            Console.WriteLine();
        }
    }
}