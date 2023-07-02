using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a  = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else 
            {
                Console.WriteLine(b);
            }
        }
    }
}