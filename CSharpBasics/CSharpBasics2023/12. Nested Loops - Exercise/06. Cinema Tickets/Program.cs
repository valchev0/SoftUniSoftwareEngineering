using System;

namespace P06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            int primeSum = 0;
            int nonPrimeSum = 0;
            while ((command = Console.ReadLine()) != "stop")
            {
                int number = int.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                if ((number == 1) || (number == 0))
                {
                    nonPrimeSum += number;
                    continue;
                }
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    primeSum+=number;
                }
                else
                {
                    nonPrimeSum+=number;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}