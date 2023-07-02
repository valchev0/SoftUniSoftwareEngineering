using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата час и минути на изпита
            int examHour = int.Parse(Console.ReadLine()); //10
            int examMin = int.Parse(Console.ReadLine()); //30
            // => преобразуваме часовете и минутите в минути 
            examMin = examMin + examHour * 60; // 30+10*60 => 630

            //2. Четем от конзолата час и минути на пристигане
            int arrivalHour = int.Parse(Console.ReadLine()); // 10
            int arrivalMin = int.Parse(Console.ReadLine()); //10
            // => преобразуваме часовете и минутите в минути 
            arrivalMin = arrivalMin + arrivalHour * 60; // 10+10*60 => 610

            //3. Намираме разликата между минутите на изпита и минутите на пристигане
            int difference = examMin - arrivalMin; //630-610 => 20

            //4. В зависимост от разликата намираме дали е закъснял, подранил или навреме 
            if (difference < 0)
            {
                Console.WriteLine("Late");
                //=> закъснял с по-малко от час
                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                else //закъснял с повече или точно час
                {
                    Console.WriteLine($"{Math.Abs(difference / 60)}:{Math.Abs(difference % 60):D2} hours after the start");
                }

            }
            else if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
                // => дошъл е до 30 мин. преди изпита 
                if (difference > 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else //difference > 30 
            {
                Console.WriteLine("Early");
                //=> подранил с по-малко от час
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                //=> подранил с повече или точно час
                else
                {
                    Console.WriteLine($"{difference / 60}:{difference % 60:D2} hours before the start");

                }
            }
        }
    }
}
