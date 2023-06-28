using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num = 541.123f;
            Console.WriteLine("{0:00.00}", num);  //514.12
        }
    }
}