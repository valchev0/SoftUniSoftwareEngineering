using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegetableAmount = int.Parse(Console.ReadLine());
            int fruitAmount = int.Parse(Console.ReadLine());

            double vegetableSum = (vegetableAmount * vegetablePrice) / 1.94;
            double fruitSum = (fruitAmount * fruitPrice) / 1.94;
            double totalSum = vegetableSum + fruitSum;
            Console.WriteLine(totalSum);
        }
    }
}