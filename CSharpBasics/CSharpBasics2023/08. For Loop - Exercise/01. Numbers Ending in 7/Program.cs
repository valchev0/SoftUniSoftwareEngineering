using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i < 1000; i += 10)
            {
                Console.WriteLine(i);
            }
            //OR
            //for (int i = 7; i <= 997; i++)
            //{
            //    if (i % 10 == 7)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
    }
}