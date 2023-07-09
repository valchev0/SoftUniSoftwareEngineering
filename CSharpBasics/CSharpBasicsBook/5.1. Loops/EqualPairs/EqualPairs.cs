using System;
namespace EqualPairs
{
    internal class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxDiffrence = 0;
            int counter = 0;
            int sum = 0;
            int lastSum = 0;
            bool isDiffrent = false;
            for (int i = 0; i < n; i++)
            {
                counter++;
                sum = 0;
                for (int j = 0; j < 2; j++)
                {
                    int currentNum = int.Parse(Console.ReadLine());
                    sum += currentNum;
                }
                if (counter > 1)
                {
                    if (lastSum != sum)
                    {
                        isDiffrent = true;
                        if (maxDiffrence < (Math.Abs(lastSum - sum)))
                        {
                            maxDiffrence = Math.Abs(lastSum - sum);
                        }
                    }
                }
                lastSum = sum;
            }
            if (!isDiffrent)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiffrence);
            }
        }
    }
}