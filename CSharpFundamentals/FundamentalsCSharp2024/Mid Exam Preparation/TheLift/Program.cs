using System;
using System.Linq;

namespace TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;

            while (people > 0 && counter < wagons.Length)
            {
                int availableSpace = 4 - wagons[counter];
                if (people >= availableSpace)
                {
                    wagons[counter] += availableSpace;
                    people -= availableSpace;
                }
                else
                {
                    wagons[counter] += people;
                    people = 0;
                }

                if (wagons[counter] == 4)
                {
                    counter++;
                }
            }

            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
            else if (wagons.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
