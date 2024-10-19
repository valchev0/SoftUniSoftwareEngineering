using System;

namespace CalculateRectangleArea
{
    internal class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int result = RectangleArea(width, height);
            Console.WriteLine(result);
        }

        private static int RectangleArea(int width, int height)
        {
            return width * height;
        }
    }
}