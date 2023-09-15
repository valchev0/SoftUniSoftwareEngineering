using System;

namespace BackIn30Minutes
{
    internal class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;

            if (minutes > 60)
            {
                minutes -= 60;
                hours++;
            }
            if (hours > 23)
            {
                hours -= 24;
            }
            Console.WriteLine("{0:0}:{1:00}", hours, minutes);
        }
    }
}