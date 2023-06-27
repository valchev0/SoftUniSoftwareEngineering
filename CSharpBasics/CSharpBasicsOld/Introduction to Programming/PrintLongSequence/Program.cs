using System;

class PrintLongSequence
{
    static void Main()
    {
        int counter = 0;
        int positive = 2; int negative = -3;
        while (counter < 1000)
        {
            if (counter % 2 != 0)
            {
                Console.WriteLine("{0}", positive);
                positive += 2;
            }
            else
            {
                Console.WriteLine("{0}", negative);
                negative -= 2;
            }
            counter++;
        }
    }
}
