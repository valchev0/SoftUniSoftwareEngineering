using System;
namespace InvalidNumber
{
    internal class InvalidNumber
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            if (number == 0 || number >= 100 && number <= 200)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}