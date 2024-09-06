using System;
namespace PipesInPool
{
    internal class PipesInPool
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int flowFirstPipework = int.Parse(Console.ReadLine()); // per hour
            int flowSecondPipework = int.Parse(Console.ReadLine()); // per hour
            double hoursForFilling = double.Parse(Console.ReadLine());

            double totalFlowFirst = flowFirstPipework * hoursForFilling;
            double totalFlowSecond = flowSecondPipework * hoursForFilling;
            double totalFlow = totalFlowFirst + totalFlowSecond;

            double firstPipeworkPercents = (totalFlowFirst / totalFlow) * 100;
            double secondPipeworkPercents = (totalFlowSecond / totalFlow) * 100;

            if (totalFlow <= capacity)
            {
                double diffrence = (totalFlow / capacity) * 100;
                Console.WriteLine("The pool is {0:0.00}% full. Pipe 1: {1:0.00}%. Pipe 2: {2:0.00}%.", diffrence, firstPipeworkPercents, secondPipeworkPercents);
            }
            else if (totalFlow > capacity)
            {
                double overflow = totalFlow - capacity;
                Console.WriteLine($"For {hoursForFilling:f2} hours the pool overflows with {overflow:f2} liters.");
            }
        }
    }
}
