using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double houseHeight = double.Parse(Console.ReadLine());
            double sideWallLength = double.Parse(Console.ReadLine());
            double heightRoof = double.Parse(Console.ReadLine());
            UnpaidAreas();
            HouseAreas(houseHeight, sideWallLength);
            RoofAreas(houseHeight, sideWallLength, heightRoof);
            double greenPaint = HouseAreas(houseHeight, sideWallLength) / 3.4;
            double redPaint = RoofAreas(houseHeight, sideWallLength, heightRoof) / 4.3;
            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);

        }

        private static double RoofAreas(double houseHeight, double sideWallLength, double heightRoof)
        {
            double triangleRoofArea = (houseHeight * heightRoof) / 2;
            double triangleRoofAreas = triangleRoofArea * 2;
            double rechangleRoofAreas = (houseHeight * sideWallLength) * 2;
            double roofAreas = triangleRoofAreas + rechangleRoofAreas;
            return roofAreas;
        }

        private static double HouseAreas(double houseHeight, double sideWallLength)
        {
            double squareWalls = (houseHeight * houseHeight) * 2;
            double rectangleWalls = (houseHeight * sideWallLength) * 2;
            double houseArea = (squareWalls + rectangleWalls - UnpaidAreas());
            return houseArea;
        }

        private static double UnpaidAreas()
        {
            double doorArea = 1.2 * 2;
            double windowsArea = (1.5 * 1.5) * 2;
            double unpaintedArea = doorArea + windowsArea;
            return unpaintedArea;
        }
    }
}