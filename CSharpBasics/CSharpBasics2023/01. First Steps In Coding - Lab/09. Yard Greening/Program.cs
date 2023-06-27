using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMetres = double.Parse(Console.ReadLine());

            double discount = (squareMetres * 7.61) * 0.18;
            double finalPrice = (squareMetres * 7.61) - discount;

            Console.WriteLine("The final price is: {0} lv.", finalPrice);
            Console.WriteLine("The discount is: {0} lv.", discount);
        }
    }
}