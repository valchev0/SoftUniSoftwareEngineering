using System;

namespace Division
{
    internal class Division
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double persantageDivision2 = 0;
            double persantageDivision3 = 0;
            double persantageDivision4 = 0;
            double persantageDivisionTotal = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum % 2 == 0)
                {
                    persantageDivision2++;
                }
                if (currentNum % 3 == 0)
                {
                    persantageDivision3++;
                }
                if (currentNum % 4 == 0) 
                {
                    persantageDivision4++;
                }
                persantageDivisionTotal++;
            }
            persantageDivision2 /= persantageDivisionTotal;
            persantageDivision3 /= persantageDivisionTotal;
            persantageDivision4 /= persantageDivisionTotal;

            Console.WriteLine("{0:p} \n{1:p} \n{2:p}", persantageDivision2, persantageDivision3, persantageDivision4);
        }
    }
}