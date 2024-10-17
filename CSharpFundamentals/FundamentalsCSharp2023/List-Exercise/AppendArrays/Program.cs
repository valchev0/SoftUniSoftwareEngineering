namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrays = input.Split('|', StringSplitOptions.RemoveEmptyEntries);
            List<int> result = new List<int>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                result.AddRange(arrays[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse));
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
