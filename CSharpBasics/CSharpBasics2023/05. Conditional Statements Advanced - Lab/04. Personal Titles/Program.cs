using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else if (age < 16) 
                {
                    Console.WriteLine("Miss");
                }
            }
            else if (gender == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else if (age < 16)
                {
                    Console.WriteLine("Master");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}