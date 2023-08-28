using System;

namespace Power
{
    internal class IsPrime
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number: ");
            string numberAsString = Console.ReadLine();
            uint number = uint.Parse(numberAsString);
            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(number);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (number % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime? {0}", prime);
        }
    }
}