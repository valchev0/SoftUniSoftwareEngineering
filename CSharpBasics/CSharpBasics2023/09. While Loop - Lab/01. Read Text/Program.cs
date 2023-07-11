using System;

namespace _01.ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(input);
            }
            //OR
            //string input = Console.ReadLine();
            //while (input != "Stop")
            //{
            //    Console.WriteLine(input);

            //    input = Console.ReadLine();
            //}
        }
    }
}