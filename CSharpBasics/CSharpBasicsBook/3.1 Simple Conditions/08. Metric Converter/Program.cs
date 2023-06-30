using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal inputNum = decimal.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            switch (inputMetric)
            {
                case "m":
                    break;
                case "mm":
                    inputNum /= 1000;
                    break;
                case "cm":
                    inputNum /= 100;
                    break;
                case "mi":
                    inputNum /= 0.000621371192m;
                    break;
                case "in":
                    inputNum /= 39.3700787m;
                    break;
                case "km":
                    inputNum /= 0.001m;
                    break;
                case "ft":
                    inputNum /= 3.2808399m;
                    break;
                case "yd":
                    inputNum /= 1.0936133m;
                    break;
            }
            switch (outputMetric)
            {
                case "m":
                    break;
                case "mm":
                    inputNum *= 1000;
                    break;
                case "cm":
                    inputNum *= 100;
                    break;
                case "mi":
                    inputNum *= 0.000621371192m;
                    break;
                case "in":
                    inputNum *= 39.3700787m;
                    break;
                case "km":
                    inputNum *= 0.001m;
                    break;
                case "ft":
                    inputNum *= 3.2808399m;
                    break;
                case "yd":
                    inputNum *= 1.0936133m;
                    break;
            }
            Console.WriteLine("{0}", inputNum);
        }
    }
}
