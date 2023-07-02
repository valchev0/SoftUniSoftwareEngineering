using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            double gpu = double.Parse(Console.ReadLine());
            double cpu = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());
            
            double gpuMoney = gpu * 250;
            double cpuMoney = cpu * (gpuMoney * 0.35);
            double ramMoney = ram * (gpuMoney * 0.1);


            double totalSum = gpuMoney + cpuMoney + ramMoney;

            if (gpu > cpu)
            {
                totalSum = totalSum * 0.85;

            }
            if (totalSum <= budget)
            {
                Console.WriteLine($"You have {budget - totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:f2} leva more!");
            }
        }
    }
}