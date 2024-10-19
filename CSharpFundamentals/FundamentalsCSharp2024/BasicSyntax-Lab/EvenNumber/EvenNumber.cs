using System;

namespace EvenNumber
{
    internal class EvenNumber
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                n = Math.Abs(int.Parse(Console.ReadLine()));
                if (n % 2 == 0)
                {
                    Console.WriteLine("The number is: {0}", n);
                    break;
                }
                else 
                { 
                    Console.WriteLine("Please write an even number."); 
                }
            }
        }
    }
}