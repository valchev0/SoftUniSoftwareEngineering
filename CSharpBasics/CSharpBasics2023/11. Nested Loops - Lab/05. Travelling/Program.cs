using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double tripPrice = double.Parse(Console.ReadLine());
                while (tripPrice > 0)
                {
                    double savings = double.Parse(Console.ReadLine());
                    tripPrice-= savings;
                }
                Console.WriteLine($"Going to {destination}!");
                destination= Console.ReadLine();

                ////OR
                //string destination = Console.ReadLine();
                //while (destination != "End")
                //{
                //    double tripCost = double.Parse(Console.ReadLine());
                //    while (tripCost > 0)
                //    {
                //        double transaction = double.Parse(Console.ReadLine());
                //        tripCost-= transaction;
                //        if (tripCost <= 0)
                //        {
                //            Console.WriteLine($"Going to {destination}!");
                //        }
                //    }
                //    destination= Console.ReadLine();
            }
        }
    }
}