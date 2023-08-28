using System;

namespace TwentyElementsPowFive
{
    internal class TwentyElementsPowFive
    {
        static void Main(string[] args)
        {
            int n = 21;
            int[] arr = new int[n];
            for (int i = 1; i < n; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}