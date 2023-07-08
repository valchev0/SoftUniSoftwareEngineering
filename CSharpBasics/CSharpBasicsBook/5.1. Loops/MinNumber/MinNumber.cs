using System;
namespace MaxNumber
{
    internal class MaxNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            var min = 100000000000;
            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (min > currentNum)
                {
                    min = currentNum;
                }
            }
            Console.WriteLine("min = {0}", min);
        }
    }
}