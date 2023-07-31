using System;

namespace Axe
{
    internal class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var leftDashes = 3 * n;
            var rightDashes = (2 * n) - 2;
            var middleDashes = 1;
            var startingStars = (3 * n) + 1;
            var middleDashes1 = n - 1;
            var middleDashes2 = n - 1;
            var middleDashes3 = n - 1;

            Console.WriteLine("{0}**{1}", new string('-', leftDashes), new string('-', rightDashes));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', middleDashes), new string('-', rightDashes - 1));
                middleDashes++;
                rightDashes--;
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}*{1}", new string('*', startingStars), new string('-', middleDashes1));
            }

            for (int i = 0; i < (n / 2) /* - 1 */; i++)
            {
                if (i + 1 == n / 2)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes - i), new string('*', middleDashes2 + i * 2), new string('-', middleDashes3 - i));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes - i), new string('-', middleDashes2 + i * 2), new string('-', middleDashes3 - i));
                    //middleDashes2++;
                    //middleDashes3--;
                }

            }

            // Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('*', middleDashes2), new string('-', middleDashes3));
        }
    }
}