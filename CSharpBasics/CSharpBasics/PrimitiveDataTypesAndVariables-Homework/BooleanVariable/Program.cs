using System;

class BooleanVariable
{
    static void Main()
    {
        bool isFemale = false; // f or m
        string gender = Console.ReadLine().ToLower();
        if (gender == "f")
        {
            isFemale = true;
        }
        Console.WriteLine(isFemale);
    }
}