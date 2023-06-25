using System;

class SomeFibonacciPrimes
{
    static void Main()
    {
        int previusNumber = 0;
        int counter = 1;
        for (int i = 0; i <= 1000; i += previusNumber)
        {
            previusNumber = i - previusNumber;
            if (i == 0)
            {
                i = 1;
            }
            Console.WriteLine(previusNumber);
            if(previusNumber == 24 || previusNumber == 101 || previusNumber == 251)
                Console.Write(" is Fibonacci nuber");
        }
    }
}