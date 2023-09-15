using System;

namespace Ages
{
    internal class Ages
    {
        static void Main(string[] args)
        {
            string inputAge = Console.ReadLine();
            int age;

            if (int.TryParse(inputAge, out age))
            {
                if (age <= 2)
                {
                    Console.WriteLine("baby");
                }
                else if (age <= 13)
                {
                    Console.WriteLine("child");
                }
                else if (age <= 19)
                {
                    Console.WriteLine("teenager");
                }
                else if (age <= 65)
                {
                    Console.WriteLine("adult");
                }
                else
                {
                    Console.WriteLine("elder");
                }
            }
            else
            {
                Console.WriteLine("Invalid age input");
            }
        }
    }
}