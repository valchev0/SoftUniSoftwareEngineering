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
            bool isOutsideRectangle = x < -1 || x > 5 || y < 1 || y > 5;

            if (isInsideCircle && isOutsideRectangle)
            {
                Console.WriteLine("Valide point.");
            }
            else
            {
                Console.WriteLine("The point is not valide.");
            }
        }
    }
}