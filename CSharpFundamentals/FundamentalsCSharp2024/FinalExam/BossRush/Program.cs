namespace BossRush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (arr.Length != 2)
                {
                    Console.WriteLine("Access denied!");
                    continue;
                }

                string rawName = arr[0];
                string rawTitle = arr[1];

                if (rawName.Length < 3 || !rawName.StartsWith('|') || !rawName.EndsWith('|'))
                {
                    Console.WriteLine("Access denied!");
                    continue;
                }

                string name = rawName.Substring(1, rawName.Length - 2);
                if (name.Length < 4 || !name.All(char.IsUpper))
                {
                    Console.WriteLine("Access denied!");
                    continue;
                }

                if (rawTitle.Length < 3 || !rawTitle.StartsWith('#') || !rawTitle.EndsWith('#'))
                {
                    Console.WriteLine("Access denied!");
                    continue;
                }

                string title = rawTitle.Substring(1, rawTitle.Length - 2);
                string[] titleWords = title.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (titleWords.Length != 2 || !titleWords.All(word => word.All(char.IsLetter)))
                {
                    Console.WriteLine("Access denied!");
                    continue;
                }

                Console.WriteLine($"{name}, The {title}");
                Console.WriteLine($">> Strength: {name.Length}");
                Console.WriteLine($">> Armor: {title.Length}");
            }
        }
    }
}
