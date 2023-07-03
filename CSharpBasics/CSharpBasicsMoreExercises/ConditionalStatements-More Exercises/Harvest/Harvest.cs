using System;
namespace Harvest
{
    internal class Harvest
    {
        static void Main(string[] args)
        {
            int vineyardSquareMeters = int.Parse(Console.ReadLine());
            double grapesPerSquareMeter = double.Parse(Console.ReadLine());
            int neededLitresWine = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double winemaking = (vineyardSquareMeters * 0.4) * grapesPerSquareMeter;
            double litresWine = winemaking / 2.5;

            if (neededLitresWine > litresWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitresWine - litresWine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litresWine)} liters.");
                var winePerPerson = (litresWine - neededLitresWine) / workersCount;
                Console.WriteLine($"{Math.Ceiling(litresWine - neededLitresWine)} liters left -> {Math.Ceiling(winePerPerson)} liters per person.");
            }
        }
    }
}
