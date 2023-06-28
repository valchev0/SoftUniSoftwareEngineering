using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstColumnAlignment = -20;
            string nameGeorge = "George";
            int agesGeorge = 18;

            string nameStan = "Stan";
            int agesStan = 20;

            Console.WriteLine("{0," + firstColumnAlignment +"}{1, 3}", "Name", "Age");
            Console.WriteLine("{0, -20}{1, 3}", nameGeorge, agesGeorge);
            Console.WriteLine("{0, -20}{1, 3}", nameStan, agesStan);
        }
    }
}