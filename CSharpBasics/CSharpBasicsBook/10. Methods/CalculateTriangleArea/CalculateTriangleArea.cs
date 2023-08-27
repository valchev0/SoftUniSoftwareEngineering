using System;

namespace CalculateTriangleArea
{
    internal class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            PrintArea();
        }

        private static void PrintArea()
        {
            int side = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = (side * height) / 2;
            Console.WriteLine(area);
        }
    }
}