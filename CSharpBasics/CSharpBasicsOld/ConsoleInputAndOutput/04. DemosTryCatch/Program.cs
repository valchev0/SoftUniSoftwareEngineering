using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Peter";
            string strAge = string.Empty;

            int age = 0;

            Console.WriteLine("Input {0}'s age: ", age);
            strAge = Console.ReadLine();

            if (Int32.TryParse(strAge, out age))
            {
                Console.WriteLine("Tomorrow {0} will be {1} old", name, age + 1);
            }
            else 
            {
                Console.WriteLine("Invalid format!");
            }
        }
    }
}