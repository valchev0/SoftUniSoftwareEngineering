using System;

namespace SmartLilly
{
    internal class SmartLilly
    {
        static void Main(string[] args)
        {
            //odd birthdays - toys, she sold them
            // even birthdays - $10+
            // even birthdays - her brother took $1
            //save money for washing mashine, are $ enoug or not?

            int lilyAge = int.Parse(Console.ReadLine());
            double washingMashine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double savings = 0;
            double birthdayMoney = 10;

            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 == 1)
                {
                    savings += toyPrice;
                }
                else
                {
                    savings += birthdayMoney;
                    savings--;
                    birthdayMoney += 10;
                }
            }
            double diffrence = Math.Abs(savings - washingMashine);
            if (savings >= washingMashine)
            {
                Console.WriteLine("Yes! {0:0.00}", diffrence);
            }
            else
            {
                Console.WriteLine("No! {0:0.00}", diffrence);
            }
        }
    }
}