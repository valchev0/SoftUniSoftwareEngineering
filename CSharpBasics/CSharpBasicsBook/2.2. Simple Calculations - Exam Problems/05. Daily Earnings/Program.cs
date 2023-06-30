using System;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int workingDaysPerMonth = int.Parse(Console.ReadLine());
            decimal salaryPerDay = decimal.Parse(Console.ReadLine());
            decimal exchangeRate = decimal.Parse(Console.ReadLine());

            decimal monthlyPayment = workingDaysPerMonth * salaryPerDay;
            decimal anualPayment = monthlyPayment * (12 + 2.5m);
            decimal withoutTaxes = anualPayment * 0.75m;
            decimal moneyInLevs = withoutTaxes * exchangeRate;
            decimal levsPerDay = moneyInLevs / 365;
            Console.WriteLine($"{levsPerDay:f2}");
        }
    }
}