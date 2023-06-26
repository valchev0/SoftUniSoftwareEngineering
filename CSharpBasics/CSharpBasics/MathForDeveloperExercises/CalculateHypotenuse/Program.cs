using System;

class CalculateHypotenuse
{
    static void Main(string[] args)
    {
        double a = 3;
        double b = 4;
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine(c);
    }
}