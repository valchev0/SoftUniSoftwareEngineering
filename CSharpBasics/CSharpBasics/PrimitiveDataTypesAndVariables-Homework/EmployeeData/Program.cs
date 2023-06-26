using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("First name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Age:");
        sbyte age = sbyte.Parse(Console.ReadLine());
        Console.WriteLine("Gender:");
        char gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Personal ID:");
        long id = long.Parse(Console.ReadLine());
        Console.WriteLine("Unique Employee number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("---------------------------");
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID: {0}", id);
        Console.WriteLine("Unique Employee number: {0}", number);
    }
}