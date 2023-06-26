using System;
using System.Net.WebSockets;

class NullValuesArithmetic
{
    static void Main()
    {
        int? integer = null;
        Console.WriteLine(integer);
        double? dec = null;
        Console.WriteLine(dec);
        integer += 5;
        Console.WriteLine(integer);
        dec += 10;
        Console.WriteLine(dec);
        integer = 5;
        Console.WriteLine(integer);
        dec = 10;
        Console.WriteLine(dec);
    }
}