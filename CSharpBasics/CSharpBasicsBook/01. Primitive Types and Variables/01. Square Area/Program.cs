using System;

class MyConsoleApp
{
    static void Main()
    {
        Console.Write("a = ");
        var a = int.Parse(Console.ReadLine());
        var area = a * a;
        Console.Write("Square area = ");
        Console.WriteLine(area);
    }
}
