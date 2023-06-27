using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double V = (length * width * height) / 1000;
            double realPercent = percent / 100;
            double total = V * (1 - realPercent);
            Console.WriteLine(total);
        }
    }
}