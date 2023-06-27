using System;

class Demos
{
    static void Main()
    {
        object toolbox = string.Empty;
        Console.WriteLine(toolbox);
        toolbox = 2222222222222222f;
        Console.WriteLine(toolbox);
        dynamic tool = "GX";
        Console.WriteLine(tool);
        tool = 56;
        Console.WriteLine(tool);
        string symbol = new String('*', 42);
        Console.WriteLine(symbol);
        Int64 integer = 22222222222222222;

        Console.WriteLine(integer);
    }
}
