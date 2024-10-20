﻿namespace GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal foodQuantity = decimal.Parse(Console.ReadLine());
            decimal hayQuantity = decimal.Parse(Console.ReadLine());
            decimal coverQuantity = decimal.Parse(Console.ReadLine());
            decimal guineaWeight = decimal.Parse(Console.ReadLine());
            int days = 30;

            bool isLoopEnd = false;
            decimal amountHay = 0;

            for (int i = 1; i <= days; i++)
            {
                if (foodQuantity >= 0.3m)
                {
                    foodQuantity -= 0.3m;
                }
                else
                {
                    isLoopEnd = true;
                    break;
                }

                if (i % 2 == 0)
                {
                    if (!isLoopEnd)
                    {
                        amountHay = foodQuantity * 0.05m;

                        if (hayQuantity >= amountHay)
                        {
                            hayQuantity -= amountHay;
                        }
                        else
                        {
                            isLoopEnd = true;
                            break;
                        }
                    }
                }
                if (i % 3 == 0)
                {
                    decimal coverNeeded = guineaWeight / 3.0m;
                    if (coverQuantity >= coverNeeded)
                    {
                        coverQuantity -= coverNeeded;
                    }
                    else
                    {
                        isLoopEnd = true;
                        break;
                    }
                }
            }

            if (!isLoopEnd)
            {
                Console.WriteLine("Everything is fine! Puppy is happy! Food: {0:0.00}, Hay: {1:0.00}, Cover: {2:0.00}.", foodQuantity, hayQuantity, coverQuantity);
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
