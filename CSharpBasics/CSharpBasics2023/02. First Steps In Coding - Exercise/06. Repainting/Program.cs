using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            
            double bag = 0.4;

            double naylonSum = (naylon + 2) * 1.5;
            double paintSum = (paint * 1.1)* 14.5;
            double diluentSum = diluent * 5;
            double paintersPayment = ((naylonSum + paintSum + diluentSum + bag) * 0.3) * hours;

            Console.WriteLine((naylonSum + paintSum + diluentSum + bag + paintersPayment));
        }
    }
}