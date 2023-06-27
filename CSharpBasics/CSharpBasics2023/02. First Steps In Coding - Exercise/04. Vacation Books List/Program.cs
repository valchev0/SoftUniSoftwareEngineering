using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hours = pages / pagesPerHour;
            double daysForReading = hours / days;

            Console.WriteLine(daysForReading);
        }
    }
}