using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum < num)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
            }
            Console.WriteLine(sum);

            //OR
            //int sum = int.Parse(Console.ReadLine());
            //int input = 0;
            //int currentSum = 0;
            //while (true)
            //{
            //    input = int.Parse(Console.ReadLine());
            //    currentSum += input;
            //    if (currentSum >= sum)
            //    {
            //        Console.WriteLine($"{currentSum}");
            //        break;
            //    }
            //}
        }
    }
}