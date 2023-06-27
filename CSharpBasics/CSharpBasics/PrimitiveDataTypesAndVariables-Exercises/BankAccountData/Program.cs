using System;

class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("First name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Middle name:");
        string middleName = Console.ReadLine();
        Console.WriteLine("Last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Available amount of money:");
        ushort balance = ushort.Parse(Console.ReadLine());
        Console.WriteLine("Bank name:");
        string bankName = Console.ReadLine();
        Console.WriteLine("IBAN:");
        float iban = float.Parse(Console.ReadLine());
        Console.WriteLine("First credit card numbers associated with the account:");
        long firstCreditCard = long.Parse(Console.ReadLine());
        Console.WriteLine("Second credit card numbers associated with the account:");
        long secondCreditCard = long.Parse(Console.ReadLine());
        Console.WriteLine("Third credit card numbers associated with the account:");
        long thirdCreditCard = long.Parse(Console.ReadLine());
        Console.WriteLine("---------------------------");
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Middle name: {0}", middleName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Available amount of money: {0}", balance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("First credit card numbers associated with the account: {0}", firstCreditCard);
        Console.WriteLine("Second credit card numbers associated with the account: {0}", secondCreditCard);
        Console.WriteLine("Third credit card numbers associated with the account: {0}", thirdCreditCard);
    }
}