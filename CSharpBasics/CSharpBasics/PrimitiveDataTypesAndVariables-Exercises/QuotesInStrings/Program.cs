using System;

class QuotesInStrings
{
    static void Main()
    {
        string quoted = "The \"use\" of quotations causes difficulties.";
        string at = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("{0}\n{1}\n", quoted, at);
    }
}