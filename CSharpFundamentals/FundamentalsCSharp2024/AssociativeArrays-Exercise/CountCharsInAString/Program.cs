namespace CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = Console.ReadLine()
                .Where(x => !char.IsWhiteSpace(x))
                .ToArray();

            Dictionary<char, int> chars = new();

            foreach (char chr in charArray)
            {
                if (!chars.ContainsKey(chr))
                {
                    chars.Add(chr, 0);
                }
                chars[chr]++;
            }
            foreach (var chr in chars)
            {
                Console.WriteLine($"{chr.Key} -> {chr.Value}");
            }
        }
    }
}
