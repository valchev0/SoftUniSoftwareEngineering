using System;
using System.Threading;
using System.Collections.Generic;
class FallingRocks
{
    struct Rocks
    {
        public int x;
        public int y;
        public string ch;
        public ConsoleColor color;
    }
    static void Position(int x, int y, string c, ConsoleColor color = ConsoleColor.Green)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void StringPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Green)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void Main()
    {
        int playfiledwidth = 61;
        int score = 0;
        int lives = 5;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 61;
        Rocks dwarf = new Rocks();
        dwarf.x = 30;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.ch = "(.)Y(.)";
        dwarf.color = ConsoleColor.Magenta;

        List<Rocks> rock = new List<Rocks>();
        Random randomGenerator = new Random();
        while (true)
        {
            {
                int chance = randomGenerator.Next(1, 100);
                Rocks newRock = new Rocks();
                Rocks newHeal = new Rocks();

                switch (randomGenerator.Next(1, 11))
                {
                    case 0:
                        newRock.color = ConsoleColor.DarkRed;
                        break;
                    case 1:
                        newRock.color = ConsoleColor.Gray;
                        break;
                    case 2:
                        newRock.color = ConsoleColor.Green;
                        break;
                    case 3:
                        newRock.color = ConsoleColor.Yellow;
                        break;
                    case 4:
                        newRock.color = ConsoleColor.DarkGray;
                        break;
                    case 5:
                        newRock.color = ConsoleColor.Blue;
                        break;
                    case 6:
                        newRock.color = ConsoleColor.DarkBlue;
                        break;
                    case 7:
                        newRock.color = ConsoleColor.DarkGreen;
                        break;
                    case 8:
                        newRock.color = ConsoleColor.DarkRed;
                        break;
                    case 9:
                        newRock.color = ConsoleColor.White;
                        break;
                    case 10:
                        newRock.color = ConsoleColor.DarkCyan;
                        break;
                }
                newRock.x = randomGenerator.Next(0, playfiledwidth);
                newRock.y = 2;
                switch (randomGenerator.Next(1, 12))
                {
                    case 0:
                        newRock.ch = "^";
                        break;
                    case 1:
                        newRock.ch = "@";
                        break;
                    case 2:
                        newRock.ch = "*";
                        break;
                    case 3:
                        newRock.ch = "&";
                        break;
                    case 4:
                        newRock.ch = "+";
                        break;
                    case 5:
                        newRock.ch = "%";
                        break;
                    case 6:
                        newRock.ch = "$";
                        break;
                    case 7:
                        newRock.ch = "#";
                        break;
                    case 8:
                        newRock.ch = "!";
                        break;
                    case 9:
                        newRock.ch = ".";
                        break;
                    case 10:
                        newRock.ch = ";";
                        break;
                    case 11:
                        if (chance > 80)
                            newRock.ch = "xXx";
                        break;
                }
                rock.Add(newRock);
            }
            //---------------------------------------------------
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey();
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x >= 1)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x <= 59 - dwarf.ch.Length)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }

            }
            List<Rocks> newList = new List<Rocks>();
            for (int i = 0; i < rock.Count; i++)
            {
                Rocks oldRocks = rock[i];
                Rocks newRocks = new Rocks();
                newRocks.x = oldRocks.x;
                newRocks.y = oldRocks.y + 1;
                newRocks.ch = oldRocks.ch;
                newRocks.color = oldRocks.color;

                if (newRocks.ch == "xXx" && newRocks.y == dwarf.y && newRocks.x + 1 == dwarf.x + 3)
                {
                    lives += 1;
                }

                if (newRocks.ch != "xXx" && newRocks.y == dwarf.y && newRocks.x == dwarf.x + 3)
                {
                    Position(dwarf.x + 2, dwarf.y, "_!_", ConsoleColor.Red);
                    lives--;
                    if (lives <= 0)
                    {
                        Console.Clear();
                        StringPosition(1, 2, "Game Over!!", ConsoleColor.Red);
                        StringPosition(1, 3, "Play Again ? Y/N ", ConsoleColor.Red);

                        ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                        while (Console.KeyAvailable)
                        {
                            Console.ReadKey();
                        }
                        if (pressedKey.Key == ConsoleKey.Y)
                        {
                            lives = 5;
                            score = 0;
                            break;
                        }
                        else if (pressedKey.Key == ConsoleKey.N)
                        {
                            Console.WriteLine();
                            return;
                        }
                    }
                }
                if (newRocks.y < Console.WindowHeight)
                {
                    newList.Add(newRocks);
                }
            }
            rock = newList;
            Console.Clear();
            Position(dwarf.x, dwarf.y, dwarf.ch, dwarf.color);
            foreach (var rocks in rock)
            {
                Position(rocks.x, rocks.y, rocks.ch, rocks.color);
            }
            StringPosition(1, 1, "Score:" + score, ConsoleColor.Gray);
            StringPosition(1, 2, "Lives:" + lives, ConsoleColor.Gray);

            Thread.Sleep(150);
            score++;
        }
    }
}