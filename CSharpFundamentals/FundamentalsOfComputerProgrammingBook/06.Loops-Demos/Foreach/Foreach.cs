using System;

namespace Foreach
{
    internal class Foreach
    {
        static void Main(string[] args)
        {
            string[] days = new string[] {
            "Monday", "Tuesday", "Wednesday",
            "Thursday", "Friday", "Saturday", "Sunday"
        };
            foreach (String day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}