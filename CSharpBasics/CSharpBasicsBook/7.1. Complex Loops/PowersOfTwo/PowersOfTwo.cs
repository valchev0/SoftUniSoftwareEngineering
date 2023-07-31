using System;

namespace NumbersOneNwithStepThree
{
    internal class NumbersOneNwithStepThree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n; i ++)
            {
                Console.WriteLine(i);
                num *= 2;
            }
        }
    }
}