using System;
namespace PrintSumOfFiveIntegers
{
    internal class PrintSumOfFiveIntegers
    {
        static void Main(string[] args)
        {
			int num = 0;
            int counter = 0;
            int sum = 0;

            while (counter < 5)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format data!");
                    continue;
                }
                sum += num;
                counter++;
            }
            Console.WriteLine(sum);
        }
    }
}