using System;
using System.Numerics;

namespace HowManyZeroesTheFactorialOfGivenNumberEnds
{
    internal class HowManyZeroesTheFactorialOfGivenNumberEnds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            while(n > 0)
            {
                factorial *= n;
                n--;
            }
            Console.WriteLine("Factorial is: {0}", factorial);
            string str = factorial.ToString();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            int zerosCounter = 0;
            foreach(char character in charArray)
            {
                if (character ==  '0')
                {
                    zerosCounter++;
                }
            }
            Console.WriteLine(zerosCounter);
        }
    }
}