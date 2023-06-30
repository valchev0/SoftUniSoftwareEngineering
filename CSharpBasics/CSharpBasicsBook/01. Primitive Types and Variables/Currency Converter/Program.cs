using System;

class MyConsoleApp
{
    static void Main()
    {
        double amount = double.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine();
        string outputCurrency = Console.ReadLine();
        double usd = 1.79549;
        double eur = 1.95583;
        double gbp = 2.53405;
        amount = inputCurrencyTobgn(amount, inputCurrency, usd, eur, gbp);
        amount = outputCurrencyConverter(amount, outputCurrency, usd, eur, gbp);
        Console.WriteLine($"{amount:f2} {outputCurrency}");
    }

    private static double outputCurrencyConverter(double amount, string outputCurrency, double usd, double eur, double gbp)
    {
        switch (outputCurrency)
        {
            case "USD":
                amount = amount / usd;
                break;
            case "EUR":
                amount = amount / eur;
                break;
            case "GBP":
                amount = amount / gbp;
                break;
        }

        return amount;
    }

    private static double inputCurrencyTobgn(double amount, string inputCurrency, double usd, double eur, double gbp)
    {
        switch (inputCurrency)
        {
            case "USD":
                amount = amount * usd;
                break;
            case "EUR":
                amount = amount * eur;
                break;
            case "GBP":
                amount = amount * gbp;
                break;
        }

        return amount;
    }
}
