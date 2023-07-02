using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number < 100) 
            {
                Console.WriteLine("Less than 100");
            }
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else 
            { 
                Console.WriteLine("Between 100 and 200"); 
            }
        }
    }
}