using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine()); 
            double percent = double.Parse(Console.ReadLine());

            Console.WriteLine(deposit + period * ((deposit * (percent / 100)) / 12));
        }
    }
}