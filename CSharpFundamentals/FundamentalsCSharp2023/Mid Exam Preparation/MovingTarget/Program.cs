namespace MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> commands =input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                int index = int.Parse(commands[1]);
                switch (commands[0])
                {
                    case "Shoot":
                        if (index > -1 && index < sequence.Count)
                        {
                            int power = int.Parse(commands[2]);
                            if (sequence[index] > power)
                            {
                                sequence[index] -= power;
                            }
                            else
                            {
                                sequence.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        if (index < 0 || index >= sequence.Count)
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        else
                        {
                            int power = (int.Parse(commands[2]));
                            sequence.Insert(index, power);
                        }
                        break;
                    case "Strike":
                        int radius = int.Parse(commands[2]);
                        if (index >= 0 && index < sequence.Count && index - radius >= 0 && index + radius < sequence.Count)
                        {
                            sequence.RemoveRange(index - radius, 2 * radius + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join('|', sequence));
        }
    }
}
