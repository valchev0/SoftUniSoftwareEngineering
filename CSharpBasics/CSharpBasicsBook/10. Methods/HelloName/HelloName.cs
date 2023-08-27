using System;

namespace HelloName
{
    internal class HelloName
    {
        static void Main(string[] args)
        {
            PrintName();
        }

        private static void PrintName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}