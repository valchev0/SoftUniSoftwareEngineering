using System;

class BirthdayDateAfter10Years
{
    static void Main()
    {
        DateOnly birthdayDate = new DateOnly(1991, 9, 1);
        DateOnly birthdayDateAfter10Years = birthdayDate.AddYears(10);
        Console.WriteLine(birthdayDateAfter10Years);

    }
}
