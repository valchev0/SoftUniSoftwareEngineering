using System;

namespace EnterEvenNumber
{
    internal class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            int n = 2;
            bool isEven = false;
            while (!isEven)
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    isEven = true;
                    break;
                }
                Console.WriteLine("The number is not even.");
            }
            Console.WriteLine("Even number entered: {0}", n);

        }
    }
}