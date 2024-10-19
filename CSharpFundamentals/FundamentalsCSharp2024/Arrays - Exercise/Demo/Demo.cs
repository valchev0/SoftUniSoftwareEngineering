using System;
using System.Threading.Channels;

namespace Demo
{
    internal class Demo
    {
        String[] days =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        Console.WriteLine(String.Join(" ", days));
    }
}