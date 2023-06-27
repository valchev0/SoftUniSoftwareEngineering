using System;

class PrintSequence
{
    static void Main()
    {
        int counter = 1;
        int positive = 2; int negative = -3;
        while (counter < 10)
        {
            if (counter % 2 != 0)
            {
                Console.Write("{0}", positive);
                positive += 2;
            }
            else
            {
                Console.Write("{0}", negative);
                negative -= 2;
            }
            counter++;
            if (counter < 10)
            {
                Console.Write(", ");
            }
        }
    }
}
