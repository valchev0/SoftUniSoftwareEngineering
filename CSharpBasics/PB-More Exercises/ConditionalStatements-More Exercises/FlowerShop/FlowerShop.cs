using System;
namespace FlowerShop
{
    internal class FlowerShop
    {
        static void Main(string[] args)
        {
            double magnolia = 3.25;
            double hyacinth = 4;
            double rose = 3.5;
            double cactus = 8;
            double tax = 0.05;

            int magnoliasQuantity = int.Parse(Console.ReadLine());
            int hyacinthsQuantity = int.Parse(Console.ReadLine());
            int rosesQuantity = int.Parse(Console.ReadLine());
            int cactiQuantity = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double magnoliasSum = magnoliasQuantity * magnolia;
            double hyacinthsSum = hyacinthsQuantity * hyacinth;
            double rosesSum = rosesQuantity * rose;
            double cactiSum = cactiQuantity * cactus;
            double flowersSum = magnoliasSum + hyacinthsSum + rosesSum + cactiSum;
            double taxesToPay = flowersSum * tax;
            double clearSum = flowersSum - taxesToPay;
            double diffrence = Math.Abs(clearSum - giftPrice);
            if (clearSum >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(diffrence));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(diffrence));
            }

        }
    }
}
