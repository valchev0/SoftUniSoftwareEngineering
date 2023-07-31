using System;

namespace Stop
{    internal class Stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('.', n + 1),
                new string('_', 2 * n + 1));

            int innerCount = 0;
            for (int i = 0; i < n; i++)
            {
                innerCount = 2 * (n + i) - 1;
                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.', n - i),
                    new string('_', innerCount));
            }

            Console.WriteLine("//{0}STOP!{0}\\\\",
                new string('_', (innerCount - 5) / 2 + 1));

            innerCount += 2;
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",
                    new string('.', n - i),
                    new string('_', innerCount - 2 * (n - i)));
            }
        }
    }
}