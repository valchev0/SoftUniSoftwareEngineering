using System;

namespace FahrenheitToCelsius
{
    internal class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());



            Console.WriteLine("Temperature in Celsius: {0}", Convertor(fahrenheit));
        }

        private static double Convertor(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }
}