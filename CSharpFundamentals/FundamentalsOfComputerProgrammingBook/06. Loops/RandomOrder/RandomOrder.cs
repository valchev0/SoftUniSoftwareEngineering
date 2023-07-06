using System;
namespace RandomOrder
{
    internal class RandomOrder
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            while (n > 0) 
            {
                Console.WriteLine(rnd.Next(n+1));
                n--;
            }
        }
    }
}