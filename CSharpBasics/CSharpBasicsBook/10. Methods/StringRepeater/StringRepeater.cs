using System;

namespace StringRepeater
{
    internal class StringRepeater
    {
        static void Main(string[] args)
        {
            StringRepeat();
        }

        private static void StringRepeat()
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(str);
            }
        }
    }
}