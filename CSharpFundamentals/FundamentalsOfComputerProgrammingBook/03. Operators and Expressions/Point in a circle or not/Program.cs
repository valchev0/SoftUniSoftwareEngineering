using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isInsideCircle = Math.Sqrt(x * x + y * y) <= 5;
            if (isInsideCircle)
            {
                Console.WriteLine("Yes, point in a circle.");
            }
            else
            {
                Console.WriteLine("No, the point is out of the circle.");
            }
        }
    }
}