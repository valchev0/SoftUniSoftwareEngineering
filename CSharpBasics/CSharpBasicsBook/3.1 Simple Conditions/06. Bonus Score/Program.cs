using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if (num <= 100)
            {
                bonusScore += 5;
            }
            else if (num > 100 && num < 1000)
            {
                bonusScore += num * 0.2;
            }
            else if(num > 1000)
            {
                bonusScore += num * 0.1;
            }
            if (num % 2 == 0)
            {
                bonusScore += 1;
            }
            if(num % 10 == 5)
            {
                bonusScore += 2;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(bonusScore + num);
        }
    }
}
