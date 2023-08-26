using System;

namespace ChangeTiles
{
    internal class ChangeTiles
    {
        static void Main(string[] args)
        {
            double savedMoney = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lengthFloor = double.Parse(Console.ReadLine());
            double sideTriangle = double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double builderPrice = double.Parse(Console.ReadLine());

            double areaFloor = widthFloor * lengthFloor;
            double areaTile = (sideTriangle * heightTriangle) / 2;
            double tileAmount = areaFloor / areaTile;
            double totalPrice = ((Math.Round(tileAmount) + 5) * tilePrice) + builderPrice;
            double diffrence = Math.Abs(totalPrice - savedMoney);

            if (totalPrice <= savedMoney)
            {
                Console.WriteLine("{0:f2} lv left.", diffrence);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", diffrence);
            }
        }
    }
}