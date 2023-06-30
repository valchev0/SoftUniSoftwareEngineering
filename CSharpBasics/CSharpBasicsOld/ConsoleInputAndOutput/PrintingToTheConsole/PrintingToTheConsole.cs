using System;
namespace PrintingToTheConsole
{
    internal class PrintingToTheConsole
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            Console.Write("{0:X}", a);
            string secondNum = double.Parse(Console.ReadLine()).Convert.ToString(b, 2);
            //Console.WriteLine("{0:X, -20}{1:B:00, 10}{2:0.00, 10}", a, b, c);
            //Console.WriteLine("{0:X, -20}{1:B:00, 10}{2:0.00, 10}", a, b, c);
            //Console.WriteLine("{0:X, -20}{1:B:00, 10}{2:0.00, 10}", a, b, c);
        }
    }
}