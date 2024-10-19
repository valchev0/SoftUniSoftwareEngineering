using System;

namespace Messages
{
    internal class Messages
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;
            char chr = ' ';
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                switch (input) 
                {
                    case 0:
                        chr = ' ';
                        break;
                    case 2:
                        chr = 'a';
                        break;
                    case 22:
                        chr = 'b';
                        break;
                    case 222:
                        chr = 'c';
                        break;
                    case 3:
                        chr = 'd';
                        break;
                    case 33:
                        chr = 'e';
                        break;
                    case 333:
                        chr = 'f';
                        break;
                    case 4:
                        chr = 'g';
                        break;
                    case 44:
                        chr = 'h';
                        break;
                    case 444:
                        chr = 'i';
                        break;
                    case 5:
                        chr = 'j';
                        break;
                    case 55:
                        chr = 'k';
                        break;
                    case 555:
                        chr = 'l';
                        break;
                    case 6:
                        chr = 'm';
                        break;
                    case 66:
                        chr = 'n';
                        break;
                    case 666:
                        chr = 'o';
                        break;
                    case 7:
                        chr = 'p';
                        break;
                    case 77:
                        chr = 'q';
                        break;
                    case 777:
                        chr = 'r';
                        break;
                    case 7777:
                        chr = 's';
                        break;
                    case 8:
                        chr = 't';
                        break;
                    case 88:
                        chr = 'u';
                        break;
                    case 888:
                        chr = 'v';
                        break;
                    case 9:
                        chr = 'w';
                        break;
                    case 99:
                        chr = 'x';
                        break;
                    case 999:
                        chr = 'y';
                        break;
                    case 9999:
                        chr = 'z';
                        break;
                }
                message += chr;
            }
            Console.WriteLine(message);
        }
    }
}