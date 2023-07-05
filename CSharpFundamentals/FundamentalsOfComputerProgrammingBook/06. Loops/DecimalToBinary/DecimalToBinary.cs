using System;
using System.Numerics;

namespace DecimalToBinary
{
    internal class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numCopy = n;
            int indicator = 0;
            int digit = 0;
            string container = string.Empty;
            string binary = string.Empty;
            while (true)
            {
                for (int i = 0; i < 1; i++)
                {
                    digit = numCopy % 2;
                    numCopy /= 2;
                }
                container += digit;
                if (numCopy <= 0)
                {
                    if (container.Length % 2 != 0)
                    {
                        container += 0;
                    }
                    if (container.Length % 4 != 0)
                    {
                        container += 0;
                    }
                    if (container.Length % 8 != 0)
                    {
                        container += 0;
                    }
                    if (container.Length < 8)
                    {
                        if (container.Length % 8 != 0)
                        {
                            container += 0;
                        }
                        if (container.Length < 8)
                        {
                            if (container.Length % 8 != 0)
                            {
                                container += 0;
                            }
                        }
                        if (container.Length < 8)
                        {
                            if (container.Length % 8 != 0)
                            {
                                container += 0;
                            }
                        }
                        if (container.Length < 8)
                        {
                            if (container.Length % 8 != 0)
                            {
                                container += 0;
                            }
                        }
                    }
                    char[] charArray = container.ToCharArray();
                    Array.Reverse(charArray);
                    binary = new string(charArray);
                    break;
                }
            }
            Console.WriteLine(binary);
        }
    }
}