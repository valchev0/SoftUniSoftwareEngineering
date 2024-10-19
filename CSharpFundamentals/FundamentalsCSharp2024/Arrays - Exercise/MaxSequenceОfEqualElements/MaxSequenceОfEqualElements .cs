using System;

namespace MaxSequenceОfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sequenceCounter = 1;
            int bestSequence = 0;
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    sequenceCounter++;
                }
                else
                {
                    sequenceCounter = 1;
                }
                if (sequenceCounter > bestSequence)
                {
                    bestSequence = sequenceCounter;
                    index = array[i];
                }
            }
            for (int i = 0; i < bestSequence; i++)
            {
                Console.Write(index + " ");
            }
        }
    }
}