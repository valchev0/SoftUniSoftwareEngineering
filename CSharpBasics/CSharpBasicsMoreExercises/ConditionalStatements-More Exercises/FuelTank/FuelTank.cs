using System;
namespace FuelTank
{
    internal class FuelTank
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine().ToLower();
            double amountFuel = double.Parse(Console.ReadLine());

            if (fuelType != "diesel" && fuelType != "gasoline" && fuelType != "gas")
            {
                Console.WriteLine("Invalid fuel!");
            }
            else if (amountFuel >= 25)
            {
                Console.WriteLine("You have enough {0}.", fuelType);
            }
            else if(amountFuel < 25)
            {
                Console.WriteLine("Fill your tank with {0}!", fuelType);
            }
        }
    }
}
