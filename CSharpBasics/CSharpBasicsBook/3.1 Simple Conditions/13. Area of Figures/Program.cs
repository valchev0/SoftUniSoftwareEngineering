using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double n1 = 1;
            double n2 = 1;
            double area = 0;

            switch (figure)
            {
                case "square":
                    n1 = double.Parse(Console.ReadLine());
                    area = n1 * n1;
                    break;
                case "rectangle":
                    n1 = double.Parse(Console.ReadLine());
                    n2 = double.Parse(Console.ReadLine());
                    area = n1 * n2;
                    break;
                case "circle":
                    n1 = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(n1, 2);
                    break;
                case "triangle":
                    n1 = double.Parse(Console.ReadLine());
                    n2 = double.Parse(Console.ReadLine());
                    area = (n1 * n2) / 2;
                    break;
            }
            Console.WriteLine(area);
        }
    }
}
