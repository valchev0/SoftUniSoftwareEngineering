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
                UpdateStarData();
                DrawStar();
                Thread.Sleep(200);
            }
        }

        static void UpdateStarData()
        {
            // TODO: Check if the star is the lower right corner and adjust velocities
            // TODO: Check if the star is the upper right corner and adjust velocities
            // TODO: Check if the star is the upper left corner and adjust velocities
            // TODO: Check if the star is the lower left corner and adjust velocities

            star.Position.x += xVelocity;
            star.Position.y += yVelocity;
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