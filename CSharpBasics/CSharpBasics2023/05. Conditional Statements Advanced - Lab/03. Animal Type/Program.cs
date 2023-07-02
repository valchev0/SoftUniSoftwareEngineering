using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal) 
            
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "reptile":
                case "tortoise":
                case "crocodile":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;    
            }
        }
    }
}