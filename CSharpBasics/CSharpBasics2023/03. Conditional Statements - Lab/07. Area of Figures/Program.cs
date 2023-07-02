using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            //double sideA = double.Parse(Console.ReadLine());
            //double sideB = double.Parse(Console.ReadLine());

            if (figure == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                double area = (sideA * sideA);
                Console.WriteLine($"{area:f2}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = (sideA * sideB);
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double area = (sideA * sideA  * Math.PI);
                Console.WriteLine($"{area:f3}");

            }
            else if(figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = ((sideA * sideB) / 2);
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}