using System;

namespace DateAfterFiveDays
{
    internal class DateAfterFiveDays
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            day += 5;
            int month = int.Parse(Console.ReadLine());
            int max = 31;

            
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                max = 30;
            }
            else if (month == 2)
            {
                max = 28;
            }
            if (day > max)
            {
                day -= max;
                month++;
            }
            if (month > 12)
            {
                month -= 12;
            }
            Console.Write(day + ".");
            if ( month < 10 )
            {
                Console.Write("0{0}", month);
            }
            else 
            { 
                Console.Write(month);
            }
        }
    }
}