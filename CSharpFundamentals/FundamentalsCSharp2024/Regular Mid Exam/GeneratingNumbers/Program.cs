//100%

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split();

                switch (input[0])
                {
                    case "add":
                        int counter = 0;
                        for (int i = 3; i < input.Length; i++)
                        {
                            sequence.Insert(counter, int.Parse(input[i]));
                            counter++;
                        }
                        break;

                    case "remove":
                        if (input[1] == "greater")
                        {
                            for (int i = sequence.Count - 1; i >= 0; i--)
                            {
                                if (sequence[i] > int.Parse(input[3]))
                                {
                                    sequence.RemoveAt(i);
                                }
                            }
                        }
                        else if (input[1] == "at")
                        {
                            int element = int.Parse(input[3]);
                            if (element >= 0 && element < sequence.Count)
                            {
                                sequence.RemoveAt(element);
                            }
                        }
                        break;

                    case "replace":
                        int oldValue = int.Parse(input[1]);
                        int newValue = int.Parse(input[2]);
                        int index = sequence.IndexOf(oldValue);
                        if (index != -1)
                        {
                            sequence[index] = newValue;
                        }
                        break;

                    case "find":
                        if (input[1] == "even")
                        {
                            foreach (var element in sequence)
                            {
                                if (element % 2 == 0)
                                {
                                    Console.Write(element + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (input[1] == "odd")
                        {
                            foreach (var element in sequence)
                            {
                                if (element % 2 != 0)
                                {
                                    Console.Write(element + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
