using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            //Value for A 
            Console.WriteLine("Enter value for A:");
            string inputA = Console.ReadLine();
            double a = double.Parse(inputA);
            //Value for C
            Console.WriteLine("Enter value for B:");
            string inputB = Console.ReadLine();
            double b = double.Parse(inputB);
            //Value for C
            Console.WriteLine("Enter value for C:");
            string inputC = Console.ReadLine();
            double c = double.Parse(inputC);
            //Solving Qadratic Equation
            double d = (b * b) - 4 * (a * c);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.WriteLine("First solution :");
            Console.WriteLine(x1);
            Console.WriteLine("Second solution :");
            Console.WriteLine(x2);
        }
    }
}