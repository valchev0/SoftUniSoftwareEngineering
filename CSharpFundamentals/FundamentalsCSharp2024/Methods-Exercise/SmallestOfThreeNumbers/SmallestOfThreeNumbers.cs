using System;

namespace SmallestOfThreeNumbers
{
    internal class SmallestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int arrayLength = 3;

                int[] array = ArrayCreation(arrayLength);

                Console.WriteLine(array.Min());
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
}