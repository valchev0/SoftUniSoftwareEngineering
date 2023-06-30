using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "s3cr3t!P@ssw0rd";
            string input = Console.ReadLine();
            if (input == correctPassword)
            {
                Console.WriteLine("Welcome");
            }
            else if (input !=  correctPassword)
            {
                Console.WriteLine("Wrong Password!");
            }
        }
    }
}
