using System;

namespace Demo
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int n = int.Parse(Console.ReadLine());
            int[] dnaSample = new int[n];

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                dnaSample = input
                   .Split('!', StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();
                
            }
            
        }
    }
}