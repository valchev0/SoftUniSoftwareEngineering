using System;
namespace Pets
{
    internal class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int petsFoodLeft = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine())/1000;

            double dogFoodTotal = dogFoodPerDay * days;
            double catFoodTotal = catFoodPerDay * days;
            double turtleFoodTotal = turtleFoodPerDay * days;
            double petsFoodNeed = dogFoodTotal + catFoodTotal + turtleFoodTotal;
            double diffrence = Math.Abs(petsFoodNeed - petsFoodLeft);

            if (petsFoodNeed <= petsFoodLeft)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(diffrence));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(diffrence));
            }
        }
    }
}
