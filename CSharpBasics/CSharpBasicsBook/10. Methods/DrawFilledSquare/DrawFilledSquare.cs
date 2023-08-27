using System;

namespace MathPower
{
    internal class DrawFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char slash = (char)92;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= 2 * n; cols++)
                {
                    if ((rows == 1 || rows == n) || (cols == 1 || cols == 2* n))
                    {
                        Console.Write('-');
                    }
                    else
                    {
                        if (cols % 2 == 0)
                        {
                            Console.Write(slash);
                        }
                        else
                        {
                            Console.Write('/');
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}