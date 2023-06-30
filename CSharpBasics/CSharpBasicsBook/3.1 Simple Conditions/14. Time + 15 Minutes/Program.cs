using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine()) + 15;

            if (minute >= 60) 
            {
                minute -= 60;
                hour++;
                if(hour >= 24) 
                {
                    hour -= 24;
                }
            }
            if (minute < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, minute);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, minute);
            }
        }
    }
}
