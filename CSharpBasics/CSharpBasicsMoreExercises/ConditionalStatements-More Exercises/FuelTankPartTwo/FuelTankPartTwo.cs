using System;
namespace FuelTankPartTwo
{
    internal class FuelTankPartTwo
    {
        static void Main(string[] args)
        {
            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;

            //if he has a club card, he can use a discount 

            double gasolineDiscount = 0.18;
            double dieselDiscount = 0.12;
            double gasDiscount = 0.08;

            //clubcard
            // between 20 - 25 litres fuel he has a discount 8%
            //more than 25 litres - 10% discount

            string fuelType = Console.ReadLine().ToLower();
            double amountFuel = double.Parse(Console.ReadLine());
            string clubcard = Console.ReadLine().ToLower();
            double sumTotal = 0;
            double sum = 0;

            if (fuelType == "gasoline")
            {
                if (clubcard == "yes")
                {
                    sum = (gasoline - gasolineDiscount) * amountFuel;
                }
                else
                {
                    sum = gasoline * amountFuel;
                }
                sumTotal = sum;
                if (amountFuel > 25)
                {
                    sumTotal *= 0.9;
                }
                else if (amountFuel >= 20 &&  amountFuel <= 25)
                {
                    sumTotal *= 0.92;
                }
            }
            if (fuelType == "diesel")
            {
                if (clubcard == "yes")
                {
                    sum = (diesel - dieselDiscount) * amountFuel;
                }
                else
                {
                    sum = diesel * amountFuel;
                }
                sumTotal = sum;
                if (amountFuel > 25)
                {
                    sumTotal *= 0.9;
                }
                else if (amountFuel >= 20 && amountFuel <= 25)
                {
                    sumTotal *= 0.92;
                }
            }
            if (fuelType == "gas")
            {
                if (clubcard == "yes")
                {
                    sum = (gas - gasDiscount) * amountFuel;
                }
                else
                {
                    sum = gas * amountFuel;
                }
                sumTotal = sum;
                if (amountFuel > 25)
                {
                    sumTotal *= 0.9;
                }
                else if (amountFuel >= 20 && amountFuel <= 25)
                {
                    sumTotal *= 0.92;
                }
            }
            Console.WriteLine("{0:0.00} lv.", sumTotal);
        }
    }
}
