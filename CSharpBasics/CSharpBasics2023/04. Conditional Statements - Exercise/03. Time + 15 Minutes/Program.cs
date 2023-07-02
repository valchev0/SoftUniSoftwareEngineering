using System;
using System.Data;

namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            if (hours == 24)
            {
                hours = 0;
            }

            if (minutes < 10) 
            {
                Console.WriteLine($"{hours}:0{minutes}");                           //minutes = minutes - 60;
            }
            else 
            {
                Console.WriteLine($"{hours}:{minutes}");
            }    
            

        }
    }
}