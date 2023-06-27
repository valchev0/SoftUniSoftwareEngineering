using System;
using System.Numerics;

class SomeFactorials
{
    static void Main(string[] args)
    {
        string input;
        while((input = Console.ReadLine()) != "End")
        {
            int number = Convert.ToInt32(input);
            BigInteger factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}