using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());    
            int litres = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double pensSum = pens * 5.8;
            double markersSum = markers * 7.2;
            double litresSum = litres * 1.2;
            double percentSum = percent / 100;

            Console.WriteLine(Math.Abs((pensSum + markersSum + litresSum) - ((pensSum + markersSum + litresSum) * percent / 100)));
        }
    }
}