namespace ListManipulationBasics
{
    internal class ListManipulationBasics
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParts = command.Split(' ');
                string action = commandParts[0];
                int number = int.Parse(commandParts[1]);
                switch (action)
                {
                    case "Add":
                        list.Add(number);
                        break;
                    case "Remove":
                        list.Remove(number);
                        break;
                    case "RemoveAt":
                        list.RemoveAt(number);
                        break;
                    case "Insert":
                        int index = int.Parse(commandParts[2]);
                        list.Insert(index, number);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
