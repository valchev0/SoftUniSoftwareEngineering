using System;

namespace ConcatNames
{
    internal class ConcatNames
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}", name, delimiter, surname);
        }
    }
}