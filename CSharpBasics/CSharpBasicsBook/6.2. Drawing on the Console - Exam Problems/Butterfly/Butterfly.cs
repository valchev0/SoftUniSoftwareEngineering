using System;

namespace Butterfly
{
    internal class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string topFirst = new string('*', n - 2) + "\\ /" + new string('*', n - 2);
            string topSecond = new string('-', n - 2) + "\\ /" + new string('-', n - 2);

            string bottomFirst = new string('*', n - 2) + "/ \\" + new string('*', n - 2);
            string bottomSecond = new string('-', n - 2) + "/ \\" + new string('-', n - 2);

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(topFirst);
                }
                else
                {
                    Console.WriteLine(topSecond);
                }
            }
            Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(bottomFirst);
                }
                else
                {
                    Console.WriteLine(bottomSecond);
                }
            }
        }
    }
}