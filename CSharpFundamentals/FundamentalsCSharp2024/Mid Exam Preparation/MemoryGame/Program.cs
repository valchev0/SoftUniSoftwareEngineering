namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;
            int counter = 1;

            while ((input = Console.ReadLine()) != "end")
            {
                int[] indexes = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                bool isFirstValid = indexes[0] >= 0 && (indexes[0] < sequence.Count);
                bool isSecondValid = indexes[1] >= 0 && (indexes[1] < sequence.Count);
                bool areSameIndexes = indexes[0] != indexes[1];

                if (isFirstValid && isSecondValid && areSameIndexes)
                {
                    if (sequence[indexes[0]] == sequence[indexes[1]])
                    {
                        string matcher = sequence[indexes[0]];
                        Console.WriteLine("Congrats! You have found matching elements - {0}!", matcher);
                        counter++;
                        if (indexes[0] > indexes[1])
                        {
                            sequence.RemoveAt(indexes[0]);
                            sequence.RemoveAt(indexes[1]);
                        }
                        else
                        {
                            sequence.RemoveAt(indexes[1]);
                            sequence.RemoveAt(indexes[0]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    int middleIndex = sequence.Count / 2;
                    string newSymbol = $"-{counter}a";
                    List<string> newElements = new List<string> { newSymbol, newSymbol };
                    sequence.InsertRange(middleIndex, newElements);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                if (sequence.Count == 0)
                {
                    Console.WriteLine("You have won in {0} turns!", counter - 1);
                    return;
                }
            }
                Console.WriteLine($"Sorry you lose :(\n{string.Join(" ", sequence)}");
        }
    }
}
