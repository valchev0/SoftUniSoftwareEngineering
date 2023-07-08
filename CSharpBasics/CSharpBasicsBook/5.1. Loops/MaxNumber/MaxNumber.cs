using System;
namespace MaxNumber
{
    internal class MaxNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            var max = -100000000000;
            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if(max < currentNum)
                {
                    max = currentNum;
                }
            }
            Console.WriteLine("max = {0}", max);
        }
    }
}