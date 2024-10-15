namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                int firstCard = firstDeck[0];
                int secondCard = secondDeck[0];

                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);

                if (firstCard > secondCard)
                {
                    firstDeck.Add(secondCard);
                    firstDeck.Add(firstCard);
                }
                else if (secondCard > firstCard)
                {
                    secondDeck.Add(firstCard);
                    secondDeck.Add(secondCard);
                }
            }

            if (firstDeck.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
        }
    }
}
