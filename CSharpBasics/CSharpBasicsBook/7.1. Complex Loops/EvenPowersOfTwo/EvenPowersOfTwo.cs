using System;

namespace EvenPowersOfTwo
{
    internal class EvenPowersOfTwo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double num = 1;
            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(num);
                num = (Math.Pow(2, 2)) * num;
            }
        }
    }
}