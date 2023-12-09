using System;

namespace BeerKegs
{
    internal class BeerKegs
    {
        static void Main(string[] args)
        {
            string biggestModelName = string.Empty;
            double biggestModelSize = double.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double size = Math.PI * Math.Pow(radius, 2) * height;
                if (size > biggestModelSize)
                {
                    biggestModelName = model;
                    biggestModelSize = size;
                }
            }
            Console.WriteLine(biggestModelName);
        }
    }
}