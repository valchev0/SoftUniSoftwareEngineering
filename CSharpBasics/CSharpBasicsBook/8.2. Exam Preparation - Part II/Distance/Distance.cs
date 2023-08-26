using System;

namespace Distance
{
    internal class Distance
    {
        static void Main(string[] args)
        {
            double kmPerHour = double.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double firstResult = kmPerHour * ((double)firstTime / 60.0);
            kmPerHour *= 1.1;
            double secondResult = kmPerHour * ((double)secondTime / 60.0);
            kmPerHour *= 0.95;
            double thirdResult = kmPerHour * ((double)thirdTime / 60.0);
            double totalResult = firstResult + secondResult + thirdResult;
            Console.WriteLine($"{totalResult:f2}");
        }
    }
}