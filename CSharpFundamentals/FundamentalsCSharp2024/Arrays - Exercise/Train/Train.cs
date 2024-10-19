using System;

namespace Train
{
    internal class Train
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];

            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(wagons.Sum());
        }
    }
}