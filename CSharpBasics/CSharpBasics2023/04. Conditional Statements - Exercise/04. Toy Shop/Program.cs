using System;
using System.Data;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double holiday = double.Parse(Console.ReadLine());
            double puzzles = double.Parse(Console.ReadLine());  
            double doll = double.Parse(Console.ReadLine()); 
            double teddy = double.Parse(Console.ReadLine());    
            double minion = double.Parse(Console.ReadLine());   
            double truck = double.Parse(Console.ReadLine());

            double puzzlesTotal = puzzles * 2.60;
            double dollTotal = doll * 3.00;
            double teddyTotal = teddy * 4.10;
            double minionTotal = minion * 8.20;
            double truckTotal = truck * 2.00;

            if (puzzles + doll + teddy + minion + truck >= 50)
            {
                double totalToys = ((puzzlesTotal + teddyTotal + dollTotal + minionTotal + truckTotal) - ((puzzlesTotal + teddyTotal + dollTotal + minionTotal + truckTotal) * 0.25));
                double rent = totalToys * 0.1;
                double totalTotal = totalToys - rent;
                double moneyHoliday = totalTotal - holiday;

                if (moneyHoliday >= 1 )
                {
                    Console.WriteLine($"Yes! {moneyHoliday:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {(-(moneyHoliday)):f2} lv needed.");
                }

            }
            else
            {
                double totalToys = (puzzlesTotal + teddyTotal + dollTotal + minionTotal + truckTotal);
                double rent = totalToys * 0.1;
                double totalTotal = (totalToys - rent);
                double moneyHoliday = totalTotal - holiday;

                if (moneyHoliday >= 1)
                {
                    Console.WriteLine($"Yes! {moneyHoliday:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {(-(moneyHoliday)):f2} lv needed.");
                }
            }
            







        }
    }
}