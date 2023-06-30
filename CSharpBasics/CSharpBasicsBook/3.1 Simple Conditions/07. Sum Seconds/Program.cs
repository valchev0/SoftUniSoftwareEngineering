using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                int time = int.Parse(Console.ReadLine());
                sum += time;
            }
            int minutes = sum / 60;
            int seconds = sum % 60;    
            
            if (minutes == 0 )
            {
                if (seconds < 10) 
                {
                    Console.WriteLine("0:0{0}", seconds);
                }
                else
                {
                    Console.WriteLine("0:{0}", seconds);
                }
            }
            else
            {
                if (seconds < 10)
                {
                    Console.WriteLine("{1}:0{0}", seconds, minutes);
                }
                else
                {
                    Console.WriteLine("{1}:{0}", seconds, minutes);
                }
            }
        }
    }
}
