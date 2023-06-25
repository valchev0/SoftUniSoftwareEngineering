using System;

class ImplementAlgorithmForEachNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        string container = string.Empty;
        bool isDone = false;
        int currentNum = 0;
        while (true)
        {
            for (int i = 0; i < input.Length; i++)
            {
                currentNum = input[i];
                int digit = 0;
                for (int j = 0; j < 10; j++)
                {
                    digit = currentNum % 2;
                    currentNum /= 2;
                    container += digit;
                    if (currentNum <=0)
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
                        char[] charArray = container.ToCharArray();
                        Array.Reverse(charArray);
                        string binary = new string(charArray);
                        Console.Write(binary + " ");
                        container = string.Empty;
                        break;
                    }
                }
                if (i == input.Length - 1)
                {
                    isDone = true;
                    break;
                }
                continue;
            }
            if (isDone)
            {
                break;
            }
        }
    }
}
