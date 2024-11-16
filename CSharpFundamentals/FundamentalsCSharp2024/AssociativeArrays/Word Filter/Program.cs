namespace Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join("\n", array));
        }
    }
}
