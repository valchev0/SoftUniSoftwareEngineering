using System;

namespace Notifications
{
    internal class Notifications
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string type = Console.ReadLine();
                string operation = string.Empty;
                string message = string.Empty;
                string errorCode = string.Empty;
                string length = string.Empty;
                string str = string.Empty;
                switch (type)
                {
                    case "success":
                        operation = Console.ReadLine();
                        message = Console.ReadLine();
                        length = "Successfully executed " + operation;
                        Console.WriteLine(length);
                        for (int j = 0; j < length.Length; j++)
                        {
                            Console.Write('=');
                        }
                        Console.WriteLine();
                        Console.WriteLine(message + ".");
                        break;
                        case "warning":
                        message = Console.ReadLine();
                        length = "Warning: " + message + '.';
                        Console.WriteLine(length);
                        for (int j = 0; j < length.Length; j++)
                        {
                            Console.Write('=');
                        }
                        break;
                    case "error":
                        operation = Console.ReadLine();
                        message = Console.ReadLine();
                        errorCode = Console.ReadLine();
                        length = "Error: Failed to execute " + operation;
                        Console.WriteLine(length);
                        for (int j = 0; j < length.Length; j++)
                        {
                            Console.Write('=');
                        }
                        Console.WriteLine();
                        Console.WriteLine("Reason: " + message + '.');
                        Console.WriteLine("Error code: " + errorCode + '.');
                        break;
                }
                if (i <= n - 2)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}