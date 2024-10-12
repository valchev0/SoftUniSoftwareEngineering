using System.Text.RegularExpressions;

namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;
            string insert = "Insert";
            string delete = "Delete";

            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Contains(delete))
                {
                    int number = int.Parse(Regex.Match(command, @"\d+").Value);
                    list.RemoveAll(n => n == number);
                }
                if (command.Contains(insert))
                {
                    string[] arr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    int item = int.Parse(Regex.Match(arr[1], @"\d+").Value);
                    int index = int.Parse(Regex.Match(arr[2], @"\d+").Value);
                    list.Insert(index, item);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
