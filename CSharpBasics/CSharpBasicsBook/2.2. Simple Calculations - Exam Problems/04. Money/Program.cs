using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double commissions = double.Parse(Console.ReadLine()) / 100;

            int levsFromBitcoins = bitcoins * 1168;
            decimal levsFromYuans = ((decimal)yuans * 0.15m) * 1.76m;
            decimal euro = ((decimal)levsFromBitcoins + levsFromYuans) / 1.95m;
            decimal commissionsSum = euro * (decimal)commissions;
            Console.WriteLine(euro - commissionsSum);
        }
    }
}