using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chCode = 0;
            while (chCode != (int)ConsoleKey.Enter) 
            {
                chCode = Console.Read();

                Console.WriteLine(chCode);
            }
        }
    }
}