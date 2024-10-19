using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationAdvanced
{
    internal class ListManipulationAdvanced
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> originalList = new List<int>(list);
            bool isChanged = false;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParts = command.Split(' ');
                string action = commandParts[0];

                switch (action)
                {
                    case "Add":
                        list.Add(int.Parse(commandParts[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        list.Remove(int.Parse(commandParts[1]));
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(commandParts[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        list.Insert(int.Parse(commandParts[2]), int.Parse(commandParts[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        Contains(list, commandParts);
                        break;
                    case "PrintEven":
                        PrintEven(list);
                        break;
                    case "PrintOdd":
                        PrintOdd(list);
                        break;
                    case "GetSum":
                        GetSum(list);
                        break;
                    case "Filter":
                        Filter(list, commandParts);
                        break;
                }
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }

        private static void Filter(List<int> list, string[] commandParts)
        {
            string condition = commandParts[1];
            int number = int.Parse(commandParts[2]);
            List<int> result = new List<int>();
            switch (condition)
            {
                case "<":
                    result = list.Where(x => x < number).ToList();
                    break;
                case ">":
                    result = list.Where(x => x > number).ToList();
                    break;
                case ">=":
                    result = list.Where(x => x >= number).ToList();
                    break;
                case "<=":
                    result = list.Where(x => x <= number).ToList();
                    break;
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void GetSum(List<int> list)
        {
            Console.WriteLine(list.Sum());
        }

        private static void PrintOdd(List<int> list)
        {
            Console.WriteLine(string.Join(" ", list.Where(x => x % 2 != 0)));
        }

        private static void PrintEven(List<int> list)
        {
            Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 0)));
        }

        private static void Contains(List<int> list, string[] commandParts)
        {
            int number = int.Parse(commandParts[1]);
            Console.WriteLine(list.Contains(number) ? "Yes" : "No such number");
        }
    }
}
