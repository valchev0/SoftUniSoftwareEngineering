using System;

namespace Continue
{
    internal class Continue
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            string numberAsString = Console.ReadLine();
            int n = int.Parse(numberAsString);

            int sum = 0;

            for (int i = 1; i <= n; i += 2)
            {
                if ((i % 7) == 0)
                    continue;
                sum += i;
            }
            Console.WriteLine("sum = {0}", sum);
        }
    }
}