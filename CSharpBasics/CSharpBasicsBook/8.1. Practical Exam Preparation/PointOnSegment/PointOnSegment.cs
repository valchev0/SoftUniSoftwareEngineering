using System;

namespace PointOnSegment
{
    internal class PointOnSegment
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine()); 
            int point = int.Parse(Console.ReadLine());  

            if (point >= Math.Min(first, second) && point <= Math.Max(first, second))
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            int firstDiffrence = Math.Abs(first - point);
            int secondDiffrence = Math.Abs(second - point);

            if (firstDiffrence < secondDiffrence)
            {
                Console.WriteLine(firstDiffrence);
            }
            else
            {
                Console.WriteLine(secondDiffrence);
            }
        }
    }
}