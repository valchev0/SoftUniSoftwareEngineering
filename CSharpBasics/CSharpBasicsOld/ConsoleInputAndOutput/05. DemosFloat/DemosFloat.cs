using System;
using System.Globalization;

namespace DemosFloat
{
    internal class DemosFloat
    {
        static void Main(string[] args)
        {
            float num = 0f;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string str = Console.ReadLine();
            str = str.Replace(',', '.');

            num = Single.Parse(str);
            Console.WriteLine(num);
        }
    }
}