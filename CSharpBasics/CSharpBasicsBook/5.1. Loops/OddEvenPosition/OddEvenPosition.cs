using System;
namespace OddEvenPosition
{
    internal class OddEvenPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            double evenSum = 0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    if (evenMin > currentNum)
                    {
                        evenMin = currentNum;
                    }
                    if (evenMax < currentNum)
                    {
                        evenMax = currentNum;
                    }
                    evenSum += currentNum;
                }
                else
                {
                    if (oddMin > currentNum)
                    {
                        oddMin = currentNum;
                    }
                    if (oddMax < currentNum)
                    {
                        oddMax = currentNum;
                    }
                    oddSum += currentNum;
                }
            }
            if (oddSum == 0)
            {
                Console.WriteLine("OddSum=0, \nOddMin=No, \nOddMax=No,");
            }
            else
            {
                Console.WriteLine("OddSum={0}, \nOddMin={1}, \nOddMax={2},", oddSum, oddMin, oddMax);
            }
            if(evenSum == 0)
            {
                Console.WriteLine("EvenSum=0, \nEvenMin=No, \nEvenMax=No");
            }
            else 
            {
                Console.WriteLine("EvenSum={0}, \nEvenMin={1}, \nEvenMax={2}", evenSum, evenMin, evenMax);
            }
        }
    }
}