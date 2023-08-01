using System;

namespace NumberInRange1To100
{
    internal class NumberInRange1To100
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool inRange = false;
            while (inRange == false)
            {
                if (num >= 1 && num <= 100)
                {
                    inRange = true; 
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}