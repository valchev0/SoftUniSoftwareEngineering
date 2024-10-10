using System;
using System.Text.RegularExpressions;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = string.Empty;
            string add = "Add";
            bool isFull = false;

            while((command = Console.ReadLine()) != "end")
            {
                if (command.Contains(add))
                {
                    int number = int.Parse(Regex.Match(command, @"\d+").Value);
                    list.Add(number);
                }
                else
                {
                    int number = int.Parse(command);
                    isFull = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + number <= maxCapacity)
                        {
                            list[i] += number;
                            isFull = true;
                            break;
                        }
                        if (isFull)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
