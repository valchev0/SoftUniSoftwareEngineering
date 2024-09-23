using System;

namespace Factorial
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            string consoleInput = Console.ReadLine();
            int n = Convert.ToInt32(consoleInput);
            decimal factorial = 1;
            //BigInteger factorial = 1;

            do
            {
                factorial *= n;
                n--;
            }
            while (n > 0);

            Console.WriteLine("n! = " + factorial);
        }
    }
}