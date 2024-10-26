/*
    100%
*/
namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            decimal pricePerKM = decimal.Parse(Console.ReadLine());
            decimal foodExpencesPerPerson = decimal.Parse(Console.ReadLine());
            decimal roomPrice = decimal.Parse(Console.ReadLine());

            decimal discount = 1m;
            if (numberOfPeople > 10)
            {
                discount = 0.75m;
            }
            decimal currentExpences = days * numberOfPeople * (foodExpencesPerPerson + roomPrice * discount);
            decimal distance = 0;
            if (currentExpences > budget)
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {(currentExpences - budget):F2}$ more.");
                return;
            }

            for (int i = 1; i <= days; i++)
            {
                distance = decimal.Parse(Console.ReadLine());
                currentExpences += distance * pricePerKM;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    currentExpences += currentExpences * 0.4m;
                }
                if (i == 7)
                {
                    currentExpences -= currentExpences / numberOfPeople;
                }
                if (currentExpences > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(budget - currentExpences):F2}$ more.");
                    return;
                }
            }
            Console.WriteLine($"You have reached the destination. You have {(budget - currentExpences):F2}$ budget left.");
        }
    }
}
