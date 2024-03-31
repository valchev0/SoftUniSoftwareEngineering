using System;

namespace Demo
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = WagonsInArray(n);
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(arr.Sum());
        }

        static int[] WagonsInArray (int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array; 
        }

    }
}