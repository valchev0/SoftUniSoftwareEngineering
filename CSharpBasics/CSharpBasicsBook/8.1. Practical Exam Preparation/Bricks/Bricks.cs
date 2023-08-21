using System;

namespace Bricks
{
    internal class Bricks
    {
        static void Main(string[] args)
        {
            double bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int wheelborrowCapacity = int.Parse(Console.ReadLine());

            double circles = (double)Math.Ceiling(bricks / (wheelborrowCapacity * workers));
            Console.WriteLine(circles);
        }
    }
}