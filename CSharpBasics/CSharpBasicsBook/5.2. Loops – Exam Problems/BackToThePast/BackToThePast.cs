using System;

namespace BackToThePast
{
    internal class BackToThePast
    {
        static void Main(string[] args)
        {
            //Ivan is 18-years old
            //even - spend $12_000
            //odd - spend $12_000 + (50 * actualAge)
            int IvanAge = 18;
            double inheritance = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            double neededMoney = 0;
            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    neededMoney += 12_000;
                }
                else
                {
                    neededMoney += 12_000 + (50 * IvanAge);
                }
                IvanAge++;
            }
            double diffrence = Math.Abs(neededMoney - inheritance);
            if (inheritance >= neededMoney)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.", diffrence);
            }
            else
            {
                Console.WriteLine("He will need {0:0.00} dollars to survive.", diffrence);
            }
        }
    }
}