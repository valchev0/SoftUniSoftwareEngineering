namespace DegustationParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Degustation> degustations = new();
            string command;
            int unliked = 0;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] arr = command.Split("-", StringSplitOptions.RemoveEmptyEntries);

                if (arr[0] == "Like")
                {
                    if (!degustations.ContainsKey(arr[1]))
                    {
                        degustations.Add(arr[1], new Degustation()
                        {
                            Name = arr[1],
                            FeedBack = arr[0],
                            Meals = new List<string>() { arr[2] }
                        });
                    }
                    else if (!degustations[arr[1]].Meals.Contains(arr[2]))
                    {
                        degustations[arr[1]].Meals.Add(arr[2]);
                    }
                }
                else if (arr[0] == "Dislike")
                {
                    if (degustations.ContainsKey(arr[1]))
                    {
                        if (degustations[arr[1]].Meals.Contains(arr[2]))
                        {
                            degustations[arr[1]].Meals.Remove(arr[2]);
                            Console.WriteLine($"{arr[1]} doesn't like the {arr[2]}.");
                            unliked++;
                        }
                        else
                        {
                            Console.WriteLine($"{arr[1]} doesn't have the {arr[2]} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{arr[1]} is not at the party.");
                    }
                }
            }

            foreach (var guest in degustations)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value.Meals)}");
            }
            Console.WriteLine($"Unliked meals: {unliked}");
        }
    }

    public class Degustation
    {
        public string Name { get; set; }

        public string FeedBack { get; set; }

        public List<string> Meals { get; set; }
    }
}
