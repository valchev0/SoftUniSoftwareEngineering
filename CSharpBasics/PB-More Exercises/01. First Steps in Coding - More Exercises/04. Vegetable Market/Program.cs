using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPriceLv = double.Parse(Console.ReadLine());
            double fruitsPriceLv = double.Parse(Console.ReadLine());
            int vegetablesWeight = int.Parse(Console.ReadLine());
            int fruitsWeight = int.Parse(Console.ReadLine());

            double sumVegLv = vegetablesPriceLv * vegetablesWeight;
            double sumFruitLv = fruitsPriceLv * fruitsWeight;
            double sumLv = sumVegLv + sumFruitLv;
            double sumInEuro = sumLv / 1.94;

            Console.WriteLine($"{sumInEuro:f2}");
        }
    }
}