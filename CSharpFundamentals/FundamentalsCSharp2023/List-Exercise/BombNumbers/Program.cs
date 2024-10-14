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
            List<int> bombs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int bomb = bombs[0];
            int bombPower = bombs[1];

            int index = list.IndexOf(bomb);

            RightExplosion(list, bombPower, index);

            LeftExplosion(list, bombPower, index);

            if (list.Contains(bombPower))
            {
                index = list.IndexOf(bomb);

                RightExplosion(list, bombPower, index);

                LeftExplosion(list, bombPower, index);
            }

            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine(list.Sum());
        }

        static void RightExplosion(List<int> list, int bombPower, int index)
        {
            if (index + bombPower > list.Count)
            {
                for (int i = index + 1; i < list.Count; i++)
                {
                    list.RemoveAt(i);
                }
            }
            else if (index + bombPower <= list.Count)
            {
                for (int i = index + 1; i < index + bombPower; i++)
                {
                    list.RemoveAt(i);
                }
            }
        }

        static void LeftExplosion(List<int> list, int bombPower, int index)
        {
            if (index >= bombPower)
            {
                for (int i = index; i >= (index - bombPower); i--)
                {
                    list.RemoveAt(i);
                }
            }
            else if (index < bombPower)
            {
                for (int i = index; i >= (bombPower - index); i--)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}
