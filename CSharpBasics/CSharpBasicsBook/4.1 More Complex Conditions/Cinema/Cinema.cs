using System;
namespace Cinema
{
    internal class Cinema
    {
        static void Main(string[] args)
        {
            string ticketTypes = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double places = rows * columns;

            switch (ticketTypes)
            {
                case "Premiere":
                    Console.WriteLine($"{places * 12:f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{places * 7.5:f2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{places * 5:f2} leva");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}