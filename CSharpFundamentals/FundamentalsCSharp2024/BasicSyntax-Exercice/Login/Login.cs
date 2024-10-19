using System;

namespace Login
{
    internal class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char chr = username[i];
                password += chr;
            }
            string input;
            int counter = 0;
            bool isFound = false;
            while (true)
            {
                input = Console.ReadLine();
                if (input == password)
                {
                    isFound = true;
                    break;
                }
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine("User {0} blocked!", username);
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
            if (password == input || isFound == true) 
            {
                Console.WriteLine("User {0} logged in.", username);
            }
        }
    }
}