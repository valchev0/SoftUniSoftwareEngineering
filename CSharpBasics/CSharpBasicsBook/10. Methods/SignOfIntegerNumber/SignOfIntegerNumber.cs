using System;

namespace SignOfIntegerNumber
{
    internal class SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
            SignIntegerNumber();
        }

        private static void SignIntegerNumber()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("The number {0} is positive.", n);
            }
            else if (n == 0)
            {
                Console.WriteLine("The number {0} is zero.", n);
            }
            else { Console.WriteLine("The number {0} is negative.", n); }
        }
    }
}