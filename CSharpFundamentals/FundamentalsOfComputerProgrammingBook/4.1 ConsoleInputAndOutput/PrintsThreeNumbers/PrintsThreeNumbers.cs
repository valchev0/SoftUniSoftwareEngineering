using System;
namespace PrintsThreeNumbers
{
    internal class PrintsThreeNumbers
    {
        static void Main(string[] args)
        {
            string hexString = Console.ReadLine();
            int firsNum = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            Console.WriteLine("{0, -10}{1:0.00, 10}{2:0.00, 20}", firsNum, secondNum, thirdNum);
        }
    }
}