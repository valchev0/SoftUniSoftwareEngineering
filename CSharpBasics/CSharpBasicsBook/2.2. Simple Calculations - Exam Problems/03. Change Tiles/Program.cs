using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int areaSide = int.Parse(Console.ReadLine());
            double tilesLength = double.Parse(Console.ReadLine());
            double tilesWidth = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());

            double areaSquare = Math.Pow(areaSide, 2);
            double tilesArea = tilesLength * tilesWidth;
            double benchArea = benchLength * benchWidth;

            double cleanArea = areaSquare - benchArea;
            double tilesQuantity = cleanArea / tilesArea;
            double timeInMinutes = tilesQuantity * 0.2;
            Console.WriteLine(tilesQuantity);
            Console.WriteLine(timeInMinutes);
        }
    }
}