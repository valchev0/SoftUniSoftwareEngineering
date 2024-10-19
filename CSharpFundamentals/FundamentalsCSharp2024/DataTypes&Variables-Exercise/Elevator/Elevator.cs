using System;

namespace Elevator
{
    internal class Elevator
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int cources = 0;

            Console.WriteLine(cources = (int)Math.Ceiling(people / capacity)) ;
        }
    }
}