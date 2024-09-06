using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerel = double.Parse(Console.ReadLine());
            double sprinkle = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double bonito = mackerel * 1.6;
            double safridKg = double.Parse(Console.ReadLine());
            double safrid = sprinkle * 1.8;
            int musselsKg = int.Parse(Console.ReadLine());
            double mussel = 7.5;

            double bonitoSum = bonito * bonitoKg;
            double safridSum = safridKg * safrid;
            double musselSum = musselsKg * mussel;
            double totalSum = bonitoSum + safridSum + musselSum;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}