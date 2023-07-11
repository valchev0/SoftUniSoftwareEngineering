using System;
using System.Security.Cryptography.X509Certificates;

namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int crew = 0;
            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;
            int crewTotal = 0;
            for (int i = 1; i <= groups; i++)
            {
                crew = int.Parse(Console.ReadLine());
                crewTotal += crew;
                if (crew < 6)
                {
                    musala += crew;
                }
                else if (crew < 13)
                {
                    monblan += crew;
                }
                else if (crew < 26)
                {
                    kilimanjaro += crew;
                }
                else if (crew < 41)
                {
                    k2 += crew;
                }
                else
                {
                    everest += crew;
                }
            }
            double musalaPercents = ((double)musala / crewTotal) * 100;
            double monblanPercents = ((double)monblan / crewTotal) * 100;
            double kilimanjaroPercents = ((double)kilimanjaro / crewTotal) * 100;
            double k2Percents = ((double)k2 / crewTotal) * 100;
            double everestPercents = ((double)everest / crewTotal) * 100;
            Console.WriteLine($"{musalaPercents:f2}%");
            Console.WriteLine($"{monblanPercents:f2}%");
            Console.WriteLine($"{kilimanjaroPercents:f2}%");
            Console.WriteLine($"{k2Percents:f2}%");
            Console.WriteLine($"{everestPercents:f2}%");
        }
    }
}