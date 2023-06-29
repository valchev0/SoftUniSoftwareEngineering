using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            Console.WriteLine("Input {0}'s age: ", age);
            string strAge = Console.ReadLine();

            try
            {
                age = Int32.Parse(strAge);
            }
            catch (FormatException)
            {

                Console.WriteLine("Wrong data format!");
            }
            catch(Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}