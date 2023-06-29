using System;

class MyConsoleApp
{
    static void Main()
    {
        int a = 5; int b = 10;
        b = b - a;
        a = a + b;
        Console.WriteLine($"a = {a}, b = {b}");
    }
}
