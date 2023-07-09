using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startTime = DateTime.Now;
            for (int i = 0; i < 100000; i++)
            {

            }
            var endTime = DateTime.Now;
            Console.WriteLine(endTime - startTime);
        }
    }
}