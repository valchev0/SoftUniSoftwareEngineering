using System;

namespace PadawanEquipment
{
    internal class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPlus = students;
            lightsaberPlus = (int)(Math.Ceiling(lightsaberPlus *= 0.1));
            double lightsaberPrice = double.Parse(Console.ReadLine());   // buy 10% more
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());   // every 6th belt is free

            int beltBonus = 0;

            if (students >= 6)
            {
                beltBonus = students / 6;
            }
            
            double lightsaberBill = (students + lightsaberPlus) * lightsaberPrice;
            double robeBill = robePrice * students;
            double beltBill = beltPrice * (students - beltBonus);
            double bill = (lightsaberBill + robeBill + beltBill);
            double diffrence = Math.Abs(bill - money);

            if (bill <= money) 
            {
                Console.WriteLine("The money is enough - it would cost {0:0.00}lv.", bill);
            }
            else
            {
                Console.WriteLine("John will need {0:0.00}lv more.", diffrence);
            }
        }
    }
}