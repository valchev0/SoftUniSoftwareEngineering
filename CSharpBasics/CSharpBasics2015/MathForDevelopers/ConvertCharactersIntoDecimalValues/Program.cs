using System;

class ConvertCharactersIntoDecimalValues
{
    static void Main()
    {
        string name = Console.ReadLine();
        for (int i = 0; i < name.Length; i++)
        {
            char ch = name[i];
            int n = ch;
            Console.WriteLine(n);
        }
    }
}
