using System;

namespace HelloName
{
    internal class HelloName
    {
        static void Main(string[] args)
        {
            NamePrinter();
        }

        private static void NamePrinter()
        {
            Console.Write("Hi, what's your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}