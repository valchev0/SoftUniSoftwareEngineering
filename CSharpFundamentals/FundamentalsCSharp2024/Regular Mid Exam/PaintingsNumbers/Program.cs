//100%

namespace Problem3
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
            int printingNumber = 0;
            int index = 0;
            int newNumber = 0;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] array = command.Split();

                switch (array[0])
                {
                    case "Change":
                        printingNumber = int.Parse(array[1]);
                        newNumber = int.Parse(array[2]);
                        if (list.Contains(printingNumber))
                        {
                            index = list.IndexOf(printingNumber);
                            list[index] = newNumber;
                        }
                        break;
                    case "Hide":
                        printingNumber = int.Parse(array[1]);
                        if (list.Contains(printingNumber))
                        {
                            list.Remove(printingNumber);
                        }
                        break;
                    case "Switch":
                        if (list.Contains(int.Parse(array[1])) && list.Contains(int.Parse(array[2])))
                        {
                            int firstIndex = list.IndexOf(int.Parse(array[1]));
                            int secondIndex = list.IndexOf(int.Parse(array[2]));
                            list[firstIndex] = int.Parse(array[2]);
                            list[secondIndex] = int.Parse(array[1]);
                        }
                        break;
                    case "Insert":
                        if (int.Parse(array[1]) > -1 && int.Parse(array[1]) < list.Count)
                        {
                            list.Insert(int.Parse(array[1]) + 1, int.Parse(array[2]));
                        }
                        break;
                    case "Reverse":
                        list.Reverse();
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
