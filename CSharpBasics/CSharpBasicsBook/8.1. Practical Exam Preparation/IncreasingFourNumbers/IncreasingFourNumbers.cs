using System;
using System.ComponentModel.Design.Serialization;

namespace IncreasingFourNumbers
{
    internal class IncreasingFourNumbers
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int count = 0;
            
            for (int i = start; i <= end; i++)
            {
                for (int j = i + 1; j <= end; j++)
                {
                    for(int k = j + 1; k <= end; k++)
                    {
                        for (int l = k + 1; l <= end; l++)
                        {
                            Console.WriteLine("{0} {1} {2} {3}", i, j, k, l);
                            count++;
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}