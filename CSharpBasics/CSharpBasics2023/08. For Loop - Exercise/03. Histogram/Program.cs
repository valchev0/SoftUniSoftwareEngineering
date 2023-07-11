using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d1Cnt = 0;
            int d2Cnt = 0;
            int d3Cnt = 0;
            int d4Cnt = 0;
            int d5Cnt = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine()); 
                if (currentNum < 200) 
                {
                d1Cnt++;
                }
                else if (currentNum >= 200 & currentNum < 400)
                {
                    d2Cnt++;
                }
                else if (currentNum >= 400 & currentNum < 600)
                {
                    d3Cnt++;
                }
                else if (currentNum >= 600 & currentNum < 800)
                {
                    d4Cnt++;
                }
                else
                {
                    d5Cnt++;
                }
            }
            double p1 = ( (double)d1Cnt / n ) * 100;  
            double p2 = ( (double)d2Cnt / n )   * 100;
            double p3 = ( (double)d3Cnt / n ) * 100;
            double p4 = ( (double)d4Cnt / n )*100;
            double p5 = ( (double)d5Cnt / n ) * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}