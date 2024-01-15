using System;

namespace RepeatString
{
    internal class RepeatString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeater(str, n));
        }

        private static string Repeater(string str, int n)
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        }
    }
}