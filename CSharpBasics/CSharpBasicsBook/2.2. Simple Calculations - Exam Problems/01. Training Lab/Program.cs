using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double rows = Math.Truncate((length * 100 / 120));
            double columns = Math.Truncate(((width * 100 - 100) / 70));
            var totalSeats = ((rows * columns) - 3);
            Console.WriteLine(totalSeats);
        }
    }
}