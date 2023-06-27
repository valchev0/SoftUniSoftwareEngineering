using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogsFoodQuantity = int.Parse(Console.ReadLine());
            int catsFoodQuantity = int.Parse(Console.ReadLine());

            double dogsFoodSum = dogsFoodQuantity * 2.5;
            double catsFoodSum = catsFoodQuantity * 4;
            double totalSum = dogsFoodSum + catsFoodSum;

            Console.WriteLine("{0} lv.", totalSum);
        }
    }
}