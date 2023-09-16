using System;

namespace ConvertMetersToKilometers
{
    internal class ConvertMetersToKilometers
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double output = input / 1000;
            Console.WriteLine("{0:0.00}", output);
        }
    }
}