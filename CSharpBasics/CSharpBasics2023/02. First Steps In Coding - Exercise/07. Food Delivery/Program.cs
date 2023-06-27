using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegeterianMenu = int.Parse(Console.ReadLine());

            double delivery = 2.5;

            double chickenSum = chickenMenu * 10.35;
            double fishSum = fishMenu * 12.4;
            double vegSum = vegeterianMenu * 8.15;
            double sumDesert = (chickenSum+ fishSum + vegSum) * 0.2;

            double totalSum = chickenSum+ fishSum + vegSum + sumDesert + delivery;
            Console.WriteLine(totalSum);
        }
    }
}