using System;

class MyConsoleApp
{
    static void Main()      
    {
        Console.Write("Enter circle radius. r = ");
        var r = double.Parse(Console.ReadLine());
        Console.WriteLine("Area = " + Math.PI * r * r);
        // Math.PI - вградена в C# константа за π
        Console.WriteLine("Perimeter = " + 2 * Math.PI * r);
    }
}
