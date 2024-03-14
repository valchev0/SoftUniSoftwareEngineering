using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PrintSomething("x");
            PrintMeSomething("y");
        }

        static string PrintSomething(string text)
        {

            return text;
            
        }
        static void PrintMeSomething(string text)
        {
            Console.WriteLine(text);
        }
    }
}