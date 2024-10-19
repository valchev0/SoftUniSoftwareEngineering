using System;

namespace WaterOverflow
{
    internal class WaterOverflow
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int n = int.Parse(Console.ReadLine());
            int totalCapacity = CAPACITY;

            for (int i = 0; i < n; i++)
            {
                int litresOfWater = int.Parse(Console.ReadLine());
                if (totalCapacity - litresOfWater >= 0)
                {
                    totalCapacity -= litresOfWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            int finalCapacity = CAPACITY - totalCapacity;
            Console.WriteLine(finalCapacity);
        }
    }
}