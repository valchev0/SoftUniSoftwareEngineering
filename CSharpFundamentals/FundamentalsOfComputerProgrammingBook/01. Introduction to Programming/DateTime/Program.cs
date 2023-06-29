using System;
using System.Globalization;

class GFG
{

    // Main Method
    public static void Main()
    {

        DateTime? a = null;
        if (!a.HasValue)
        {
            a = DateTime.Now;
            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }
        }

    }
}