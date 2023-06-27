using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yearTax = double.Parse(Console.ReadLine());

            double runners = yearTax * 0.6;
            double uniform = runners * 0.8;
            double ball = uniform * 0.25;
            double accesories = ball * 0.2;

            Console.WriteLine(yearTax + runners + uniform + ball + accesories);
        }
    }
}