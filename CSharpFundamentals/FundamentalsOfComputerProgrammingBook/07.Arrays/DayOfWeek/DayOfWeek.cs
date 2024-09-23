using System;

namespace DayOfWeek
{
    internal class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] arr =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int n = int.Parse(Console.ReadLine()) - 1;

            if (n >= 0 && n <= 6)
            {
                Console.WriteLine(arr[n]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}