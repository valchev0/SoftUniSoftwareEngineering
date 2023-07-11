using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int topSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                topSum += currentNumber;   
            }
            int bottomSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                bottomSum += currentNumber;
            }
            // TODO: read and calculate the rightSum
            if (topSum == bottomSum)
            {
                Console.WriteLine("Yes, sum = " + topSum);
            }
            else
            {
                int diff = Math.Abs(topSum - bottomSum);
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}