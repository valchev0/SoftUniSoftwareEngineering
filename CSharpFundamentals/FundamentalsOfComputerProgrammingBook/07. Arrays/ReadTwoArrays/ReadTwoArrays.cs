using System;

namespace ReadTwoArrays
{
    internal class ReadTwoArrays
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            foreach (string day in days)
            {
                Console.WriteLine(day);
            }
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }
    }
}