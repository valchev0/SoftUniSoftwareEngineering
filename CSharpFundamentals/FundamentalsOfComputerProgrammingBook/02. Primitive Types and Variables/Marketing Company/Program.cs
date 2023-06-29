using System;

class MyConsoleApp
{
    static void Main()
    {
        Console.WriteLine("First name, please:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Surname, please:");
        string surname = Console.ReadLine();
        Console.WriteLine("Age, please:");
        sbyte age = sbyte.Parse(Console.ReadLine());
        Console.WriteLine("Gender, please (m / f):");
        char charGender = char.Parse(Console.ReadLine());
        Console.WriteLine("Your unique number, please:");
        int number = int.Parse(Console.ReadLine());
        string gender;
        if (charGender == 'm' || charGender == 'M')
        {
            gender = "Sir";
        }
        else
        {
            gender = "Madam";
        }
        Console.WriteLine($"{gender} your name is: {firstName} {surname}, with unique number: {number}.");

    }
}
