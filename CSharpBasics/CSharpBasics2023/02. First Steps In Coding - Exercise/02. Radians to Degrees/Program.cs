using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());

            Console.WriteLine(radian * (180/Math.PI));
        }
    }
}