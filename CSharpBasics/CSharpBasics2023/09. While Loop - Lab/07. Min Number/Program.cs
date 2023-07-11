using System;


namespace My_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            int input = 0;
            int MinNumber = int.MaxValue;
            while ((command = Console.ReadLine()) != "Stop")
            {
                input = int.Parse(command);
                if (input < MinNumber)
                {
                    MinNumber = input;
                }
            }
            Console.WriteLine(MinNumber);
        }
    }
}