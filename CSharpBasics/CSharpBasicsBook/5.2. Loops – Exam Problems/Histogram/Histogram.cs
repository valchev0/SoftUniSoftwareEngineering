using System;

namespace Histogram
{
    internal class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double pSum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > 0 && currentNum < 200)
                {
                    p1++;
                }
                else if (currentNum >= 200 && currentNum <= 399)
                {
                    p2++;
                }
                else if (currentNum >= 400 &&  currentNum <= 599)
                {
                    p3++;
                }
                else if (currentNum >= 600 &&  currentNum <= 799)
                {
                    p4++;
                }
                else if(currentNum >= 800)
                {
                    p5++;
                }
                pSum++;
            }
            p1 /= pSum;
            p2 /= pSum;
            p3 /= pSum;
            p4 /= pSum;
            p5 /= pSum;
            Console.WriteLine("{0:p} \n{1:p} \n{2:p} \n{3:p} \n{4:p}", p1, p2, p3, p4, p5);
        }
    }
}