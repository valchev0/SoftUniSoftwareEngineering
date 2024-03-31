using System;

namespace VowelsCount
{
    internal class VowelsCount
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            char[] vowels =
            {
                'a',
                'e',
                'i',
                'o',
                'u',
                'y'
            };

            char[] charArray = StringToCharArray(str);

            Console.WriteLine(VowelsContainer(charArray, vowels));

        }
        
        static char[] StringToCharArray(string str)
        {
            char[] charAarray = str.ToCharArray();
            
            return charAarray;
        }

        static int VowelsContainer(char[] charArray, char[] vowels)
        {
            int counter = 0;

            foreach (char chr in charArray)
            {
                if (vowels.Contains(chr))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}