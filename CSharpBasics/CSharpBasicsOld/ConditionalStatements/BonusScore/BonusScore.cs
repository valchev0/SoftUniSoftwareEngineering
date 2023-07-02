using System;
namespace BonusScore
{
    internal class BonusScore
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            switch (points)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(points * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(points * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(points * 1000);
                    break;
                default:
                    Console.WriteLine("Invalid score");
                    break;
            }

        }
    }
}