namespace Demo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] dnaSample = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            }
        }
    }
}