using System;

class UnicodeCharacter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char character = (char)n;
        Console.WriteLine(character);
    }
}