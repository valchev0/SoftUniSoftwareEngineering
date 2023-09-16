using System;

namespace Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double coffeePrice = 0;
            double sumTotal = 0;

            for (int i = 0; i < n; i++)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                coffeePrice = (days * capsules) *priceCapsule;
                Console.WriteLine("The price for the coffee is: ${0:0.00}", coffeePrice);
                sumTotal += coffeePrice;
            }
            Console.WriteLine("Total: ${0:0.00}", sumTotal);
        }
    }
}