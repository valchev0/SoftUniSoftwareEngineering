using System;

namespace DrawFort
{
    internal class DrawFort
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int width = 2 * num;
            int row = num / 2;

            Console.WriteLine(@"/{0}\{1}/{0}\", new string('^', row), new string('_', width - ((2 * row) + 4)));

            for (int i = 0; i < num - 3; i++)
            {
                for (int j = 0; j < 2 * num; j++)
                {
                    if (j == 0 || j == 2 * num - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("|{0}{1}{0}|", new string(' ', row + 1), new string('_', width - ((2 * row) + 4)));
            Console.WriteLine(@"\{0}/{1}\{0}/", new string('_', row), new string(' ', width - ((2 * row) + 4)));
        }
    }
}