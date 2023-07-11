using System;

namespace P06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());

            int totalPieces = cakeLength * cakeWidth; //Pieces count = Area of the rectangle

            string command;
            while ((command = Console.ReadLine()) != "STOP")
            {
                int piecesTaken = int.Parse(command);

                totalPieces -= piecesTaken;
                if (totalPieces < 0)
                {
                    break;
                }
            }

            if (totalPieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
            else
            {
                //0 pieces are left!!!
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
            //OR
            //int width = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //int pieces = width * height;
            //string input = string.Empty;
            //while (((input = Console.ReadLine()) != "STOP") && (pieces > 0))
            //{
            //    int taken = int.Parse(input);
            //    pieces -= taken;
            //    if (pieces < 1)
            //    {
            //        Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
            //        break;
            //    }
            //}
            //if (pieces > 0)
            //{
            //    Console.WriteLine($"{pieces} pieces are left.");
            //}

            //OR
            //int width = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //int total = width * height;
            //string command;
            //int pieces;
            //int taken = 0;

            //while ((command = Console.ReadLine()) != "STOP")
            //{
            //    pieces = int.Parse(command);
            //    total -= pieces;
            //    if (total <= 0)
            //    {
            //        Console.WriteLine($"No more cake left! You need {Math.Abs(total)} pieces more.");
            //        break;
            //    }
            //}
            //if (command == "STOP")
            //{
            //    if (total <= 0)
            //    {
            //        Console.WriteLine($"No more cake left! You need {Math.Abs(total)} pieces more.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{total} pieces are left.");
            //    }
            //}
        }
    }
}