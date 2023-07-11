using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double accountBalance = 0;
            string input;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double depositAmount = double.Parse(input);

                if (depositAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                accountBalance += depositAmount;
                Console.WriteLine($"Increase: {depositAmount:f2}");
            }

            Console.WriteLine($"Total: {accountBalance:f2}");
        }
    }
}