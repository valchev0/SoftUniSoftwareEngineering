using System;
namespace FindPerimeterAndArea
{
    internal class FindPerimeterAndArea
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Perimeter is {0:0.00}", perimeter);

            double area = Math.PI * (Math.Pow(radius, 2));
            Console.WriteLine("Area is {0:0.00}", area);
        }
    }
}