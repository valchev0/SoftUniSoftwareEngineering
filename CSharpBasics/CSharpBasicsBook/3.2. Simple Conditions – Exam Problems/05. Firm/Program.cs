using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            int availableHours = (int)Math.Floor((availableDays - (availableDays * 0.1)) * employees * 10);
            int hoursDiffrence = Math.Abs(availableHours - neededHours);

            if (neededHours <= availableHours)
            {
                Console.WriteLine($"Yes!{hoursDiffrence} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursDiffrence} hours needed.");
            }
        }
    }
}