using System;

namespace StupidPasswordGenerator
{
    internal class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = 1; i < firstNum; i++)
            {
                for (int j = 1; j < firstNum; j++)
                {
                    for(char k = 'a'; k < 'a' + secondNum; k++)
                    {
                        for (int l = 97; l < 97 + secondNum; l++)
                        {
                            for (int m = Math.Max(i, j) + 1; m <= firstNum; m++)
                            {
                                Console.Write($"{i}{j}{k}{(char)l}{m} ");
                            }
                        }
                    }
                }
            }
        }
    }
}