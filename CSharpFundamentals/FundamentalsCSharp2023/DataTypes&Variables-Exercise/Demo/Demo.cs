using System;

namespace Demo
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            

            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = (int)char.GetNumericValue(input[i]);
                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}