using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
        static int[] ArrayCreation(int arrayLength)
        {
            int[] arr = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
    }
}