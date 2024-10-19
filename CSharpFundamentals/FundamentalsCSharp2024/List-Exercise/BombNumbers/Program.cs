namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] bombs = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int bomb = bombs[0];
            int bombPower = bombs[1];

            while (list.Contains(bomb))
            {
                int index = list.IndexOf(bomb);

                int leftIndex = Math.Max(0, index - bombPower);
                int rightIndex = Math.Min(list.Count - 1, index + bombPower);

                int countToRemove = rightIndex - leftIndex + 1;
                list.RemoveRange(leftIndex, countToRemove);
            }

            Console.WriteLine(list.Sum());
        }
    }
}
