using System;

namespace Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double price = 0;
            double sum = 0;
            sum = OrderSum(product, n, ref price);
            Console.WriteLine(sum);
        }

        private static double OrderSum(string product, int n, ref double price)
        {
            double sum;
            switch (product)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2;
                    break;
            }
            sum = price * n;
            return sum;
        }
    }
}