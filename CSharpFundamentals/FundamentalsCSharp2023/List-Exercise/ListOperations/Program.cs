using System.ComponentModel.Design;

namespace ListOperations
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

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (arr[0])
                {
                    case "Add":
                        list.Add(int.Parse(arr[1]));
                        break;
                    case "Insert":
                        int indexToInsert = int.Parse(arr[2]);
                        if (indexToInsert >= 0 && indexToInsert <= list.Count)
                        {
                            list.Insert(indexToInsert, int.Parse(arr[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(arr[1]);
                        if (indexToRemove >= 0 && indexToRemove < list.Count)
                        {
                            list.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        if (arr[1] == "left")
                        {
                            int n = int.Parse(arr[2]);
                            n = n % list.Count;
                            List<int> rotatedList = new List<int>(list.Count);
                            rotatedList.AddRange(list.GetRange(n, list.Count - n));
                            rotatedList.AddRange(list.GetRange(0, n));
                            list = rotatedList;
                        }
                        if (arr[1] == "right")
                        {
                            int n = int.Parse(arr[2]);
                            n = n % list.Count;
                            List<int> rotatedList = new List<int>(list.Count);
                            rotatedList.AddRange(list.GetRange(list.Count - n, n));
                            rotatedList.AddRange(list.GetRange(0, list.Count - n));
                            list = rotatedList;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
