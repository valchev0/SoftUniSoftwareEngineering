using System;

namespace RectangleWithStars
{
    internal class RectangleWithStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            bool middle = false;
            if (n % 2 == 0 )
            {
                num += n + 1;
            }
            else
            {
                num += n + 2;
            }
            int mid = num / 2;
            for (int rows = 0; rows < num; rows++)
            {
                for (int cols = 0; cols < n * 2; cols++)
                {
                    int mark = 0;
                    if (rows == 0 || rows == num - 1 || cols == 0 || cols == (n * 2) - 1)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        if (n == 2)
                        {
                            if (rows == num / 2)
                            {
                                if (cols == num / 2 || cols == num / 2 + 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            int point = 0;
                            if (rows == num / 2)
                            {
                                if (!middle && cols == n -1 || cols == n)
                                {
                                    Console.Write("*");
                                    point = 1;
                                    middle = true;
                                }
                                else
                                {
                                        Console.Write(" ");
                                }
                            }
                            else
                            {
                                    Console.Write(" ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}