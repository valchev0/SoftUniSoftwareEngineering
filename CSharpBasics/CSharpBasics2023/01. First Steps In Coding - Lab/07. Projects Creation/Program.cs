using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            int hours = projects * 3;

            Console.WriteLine("The architect {0} will need {2} hours to complete {1} project/s.", architectName, projects, hours);
        }
    }
}