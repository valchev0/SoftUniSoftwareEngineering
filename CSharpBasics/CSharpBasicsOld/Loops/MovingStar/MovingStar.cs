using System;
namespace MovingStar
{
    internal class MovingStar
    {
        struct Point
        {
            public int x;
            public int y;
        }
        struct Star
        {
            public Point Position;
        }

        static int WindowHeight = 20;
        static int WindowWidth = 30;

        // This is the star object to be used.
        static Star star = new Star();

        // These fields represent the rate of change of the star's x and y values
        static int xVelocity = 0;
        static int yVelocity = 0;

        static void PrintOnPosition(int row, int col, string str, ConsoleColor color)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void InitSettings()
        {
            Console.WindowHeight = WindowHeight;
            Console.WindowWidth = WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.CursorVisible = false;
            Console.Clear();
        }

        static void Main()
        {
            InitSettings();
            star.Position.x = WindowHeight - 1;
            star.Position.y = 5;

            while (true)
            {
                ClearStar();
                ReadInput();
                UpdateStarData();
                DrawStar();
                Thread.Sleep(200);
            }
        }

        static void ReadInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (userInput.Key == ConsoleKey.DownArrow && star.Position.x < WindowHeight - 1)
                {
                    xVelocity = 1;
                    yVelocity = 0;
                }
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    xVelocity = -1;
                    yVelocity = 0;
                }
                if (userInput.Key == ConsoleKey.LeftArrow)
                {
                    xVelocity = 0;
                    yVelocity = -1;
                }
                if (userInput.Key == ConsoleKey.RightArrow)
                {
                    xVelocity = 0;
                    yVelocity = 1;
                }
            }
        }
        static void UpdateStarData()
        {
            star.Position.x += xVelocity;
            star.Position.y += yVelocity;

            xVelocity = 0;
            yVelocity = 0;
        }

        static void ClearStar()
        {
            PrintOnPosition(star.Position.x, star.Position.y, " ", ConsoleColor.Red);
        }

        static void DrawStar()
        {
            PrintOnPosition(star.Position.x, star.Position.y, "*", ConsoleColor.Red);
        }
    }
}