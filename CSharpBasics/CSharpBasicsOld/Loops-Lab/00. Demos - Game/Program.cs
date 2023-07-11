using System;
namespace MyConsoleApp
{
    internal class Game
    {
        static int WindowHeight = 20;
        static int WindowWidth = 30;

        static void PrintOnPosition(int row, int col, string str, ConsoleColor color)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = color;
            Console.Write(str);
        }
        static void InitSettings()
        {
            Console.WindowHeight = WindowHeight;
            Console.WindowHeight = WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.CursorVisible = false;
            Console.Clear();
        }
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            if(row < 2 || row >= WindowHeight - 2 || col < 0 || col >= WindowWidth - 4)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            InitSettings();
            PrintOnPosition(row, col, "*", ConsoleColor.Green);
            PrintOnPosition(row - 1, col + 1, "*", ConsoleColor.Green);
            PrintOnPosition(row - 2, col + 2, "*", ConsoleColor.Green);
            PrintOnPosition(row - 1, col + 3, "*", ConsoleColor.Green);
            PrintOnPosition(row, col + 4, "*", ConsoleColor.Green);
            PrintOnPosition(row + 1, col + 3, "*", ConsoleColor.Green);
            PrintOnPosition(row + 2, col + 2, "*", ConsoleColor.Green);
            PrintOnPosition(row + 1, col + 1, "*", ConsoleColor.Green);


            Console.ReadLine();
        }
    }
}