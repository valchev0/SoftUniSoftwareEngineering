using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int homeFreeSpace = width * lenght * hight;
            string input = Console.ReadLine();
            while (input != "Done")
            {
                int currentBox = int.Parse(input);
                homeFreeSpace -= currentBox;
                if (homeFreeSpace <= 0)
                {
                    int difference = Math.Abs(homeFreeSpace);
                    Console.WriteLine($"No more free space! You need {difference} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (homeFreeSpace > 0)
            {
                Console.WriteLine($"{homeFreeSpace} Cubic meters left.");
            }

            //OR
            //int width = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //int length = int.Parse(Console.ReadLine());
            //int totalBoxes = width * height * length;
            //string input;
            //while (((input = Console.ReadLine()) != "Done") && (totalBoxes > 0))
            //{
            //    int boxes = int.Parse(input);
            //    totalBoxes -= boxes;
            //    if (totalBoxes <= 0)
            //    {
            //        Console.WriteLine($"No more free space! You need {Math.Abs(totalBoxes)} Cubic meters more.");
            //        break;
            //    }
            //}
            //if (totalBoxes > 0)
            //{
            //    Console.WriteLine($"{totalBoxes} Cubic meters left.");
            //}

            //OR
            //int width = int.Parse(Console.ReadLine());
            //int length = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //int total = width * height * length;
            //string command;
            //int boxes;


            //while ((command = Console.ReadLine()) != "Done")
            //{
            //    boxes = int.Parse(command);
            //    total -= boxes;
            //    if (total <= 0)
            //    {
            //        Console.WriteLine($"No more free space! You need {Math.Abs(total)} Cubic meters more.");
            //        break;
            //    }
            //}
            //if (total > 0) { Console.WriteLine($"{Math.Abs(total)} Cubic meters left."); }
        }
    }
}