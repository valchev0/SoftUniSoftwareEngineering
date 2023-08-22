using System;

namespace SumsStepThree
{
    internal class SumsStepThree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;
            int thirdSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i % 3 == 1)
                {
                    firstSum += currentNum;
                }
                else if (i % 3 == 2)
                { 
                    secondSum += currentNum; 
                }
                else
                {
                    thirdSum += currentNum;
                }
            }
            Console.WriteLine("sum1 = {0} \nsum2 = {1} \nsum3 = {2}", firstSum, secondSum, thirdSum);
        }
    }
}