using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine()) - 1;
            int area = (((int)(height / 0.7)) * (int)(width / 1.2)) - 3;
            Console.WriteLine(area);
        }
    }
}