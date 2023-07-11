using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 1; i <= n ; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < 200 )
                {
                    p1++;
                }
                else if (currentNumber < 400)
                {
                    p2++;
                }
                else if (currentNumber < 600)
                {
                    p3++;
                }
                else if (currentNumber < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            double p1Percents = p1/n* 100;
            double p2Percents = p2 / n * 100;
            double p3Percents = p3 / n * 100;
            double p4Percents = p4 / n * 100;
            double p5Percents = p5 / n * 100;


            
            Console.WriteLine($"{p1Percents:f2}%");
            Console.WriteLine($"{p2Percents:f2}%");
            Console.WriteLine($"{p3Percents:f2}%");
            Console.WriteLine($"{p4Percents:f2}%");
            Console.WriteLine($"{p5Percents:f2}%");
        }
    }
}