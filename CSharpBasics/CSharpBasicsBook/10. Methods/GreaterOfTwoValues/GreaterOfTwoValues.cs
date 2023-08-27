using System;

namespace GreaterOfTwoValues
{
    internal class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            GetMax(type);
        }

        private static void GetMax(string type)
        {
            if (type == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                if (firstNum >= secondNum)
                {
                    Console.WriteLine(firstNum);
                }
                else
                {
                    Console.WriteLine(secondNum);
                }
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                if (firstChar >= secondChar)
                {
                    Console.WriteLine(firstChar);
                }
                else { Console.WriteLine(secondChar); }
            }
            else if (type == "string")
            {
                string firstStr = Console.ReadLine();
                string secondStr = Console.ReadLine();
                if (firstStr.CompareTo(secondStr) >= 0)
                {
                    Console.WriteLine(firstStr);
                }
                else
                {
                    Console.WriteLine(secondStr);
                }
            }
        }
    }
}