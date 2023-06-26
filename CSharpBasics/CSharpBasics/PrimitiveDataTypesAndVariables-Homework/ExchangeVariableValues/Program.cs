using System;

class ExchangeVariableValues
{
    static void Main()
    {
        Console.WriteLine("Befor:");
        var a = 5;
        Console.WriteLine("a = 5");
        var b = 10;
        Console.WriteLine("b = 10");
        b = b - a;
        a = b + a;
        Console.WriteLine("After:");
        Console.WriteLine("a = 10");
        Console.WriteLine("b = 5");
    }
}