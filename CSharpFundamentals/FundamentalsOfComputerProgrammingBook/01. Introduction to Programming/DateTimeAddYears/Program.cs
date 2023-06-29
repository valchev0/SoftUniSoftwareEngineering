// C# program to demonstrate the
// DateTime.AddYears(Int32) Method
using System;
using System.Globalization;

class GFG
{

    // Main Method
    public static void Main()
    {

        try
        {

            // creating object of DateTime
            DateTime date1 = new DateTime(2023, 6, 14,
                                            4, 0, 15);

            // adding the 8 Months
            // using AddYears() method;
            DateTime date2 = date1.AddYears(8);

            // Display the date1
            Console.WriteLine("DateTime before operation: "
                                  + "{0:y} {0:dd}", date1);

            // Display the date2
            Console.WriteLine("\nDateTime after operation: "
                                  + "{0:y} {0:dd}", date2);

        }

        catch (ArgumentOutOfRangeException e)
        {
            Console.Write("Exception Thrown: ");
            Console.Write("{0}", e.GetType(), e.Message);
        }
    }
}