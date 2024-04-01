using System;

namespace PasswordValidator
{
    internal class PasswordValidator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] charArray = new char[password.Length];
            charArray = password.ToUpper().ToCharArray();

            PrintResult(charArray);
        }

        static bool PasswordLength(char[] charArray)
        {
            bool isCorrectLength = true;
            int passMinLength = 6;
            int passMaxLength = 10;

            if (charArray.Length < passMinLength || charArray.Length > passMaxLength)
            {
                //Console.WriteLine("Password must be between 6 and 10 characters");
                return !isCorrectLength;
            }

            return isCorrectLength;
        }

        static bool PasswordConsist(char[] charArray)
        {
            bool isConsistLettersAndDigits = true;
            int letterStart = (int)'A';
            int letterEnd = (int)'Z';
            int digitStart = (int)'0';
            int digitEnd = (int)'9';

            for (int i = 0; i < charArray.Length; i++)
            {
                int temp = (int)charArray[i];
                if ((temp < letterStart || temp > letterEnd) && (temp < digitStart || temp > letterEnd))
                {
                    //Console.WriteLine("Password must consist only of letters and digits");
                    return !isConsistLettersAndDigits;
                }
            }

            return isConsistLettersAndDigits;
        }

        static bool ContainsAtLeastTwoDigits(char[] charArray)
        {
            bool areFoundTwoDigits = false;
            int start = (int)'0';
            int end = (int)'9';

            int digitCounter = 0;

            foreach (var chr in charArray)
            {
                if (chr >= start && chr <= end)
                {
                    digitCounter++;

                    if (digitCounter >= 2)
                    {
                        return areFoundTwoDigits;
                    }
                }
            }

            //Console.WriteLine("Password must have at least 2 digits");
            return !areFoundTwoDigits;
        }

        static void PrintResult(char[] charArray)
        {
            bool isCorrectLength = PasswordLength(charArray);
            bool isConsistLettersAndDigits = PasswordConsist(charArray);
            bool areFoundTwoDigits = ContainsAtLeastTwoDigits(charArray);

            if (!isCorrectLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isConsistLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!areFoundTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isCorrectLength && isConsistLettersAndDigits && areFoundTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}