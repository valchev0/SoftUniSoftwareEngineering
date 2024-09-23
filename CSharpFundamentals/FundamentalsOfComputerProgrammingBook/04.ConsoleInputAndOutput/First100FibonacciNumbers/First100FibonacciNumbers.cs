using System;
namespace First100FibonacciNumbers
{
    internal class First100FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = 1;
            int previousNumber = 0;
            int fibonacciCounter = 0;

            while(fibonacciCounter < 100)
            {
                n += previousNumber;
                Console.WriteLine(previousNumber);
                previousNumber = n - previousNumber;
                fibonacciCounter++;
            }
        }
    }
}