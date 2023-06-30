using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int pipeOne = int.Parse(Console.ReadLine());
            int pipeTwo = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double waterPipeOne = hours * pipeOne;
            double waterPipeTwo = hours * pipeTwo;
            double waterBothPipes = waterPipeOne + waterPipeTwo;
            double waterPercentages = (waterBothPipes / capacity) * 100;
            double pipeOnePercentages = (waterPipeOne / waterBothPipes) * 100;
            double pipeTwoPercentages = (waterPipeTwo / waterBothPipes) * 100;
            if (capacity <= waterBothPipes)
            {
                if (capacity == waterBothPipes)
                {
                    Console.WriteLine($"The pool is 100% full. Pipe 1: {Math.Truncate(pipeOnePercentages)}%. Pipe 2: {Math.Truncate(pipeOnePercentages)}%.");
                }
                else
                {
                    Console.WriteLine($"For {hours} hours the pool overflows with {waterBothPipes - capacity} liters.");
                }
            }
            else
            {
                Console.WriteLine($"The pool is {Math.Truncate(waterPercentages)}% full. Pipe 1: {Math.Truncate(pipeOnePercentages)}%. Pipe 2: {Math.Truncate(pipeTwoPercentages)}%.");
            }
        }
    }
}