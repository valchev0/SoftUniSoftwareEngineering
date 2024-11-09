namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> map = new Dictionary<double, int>();

            foreach (double element in array)
            {
                if (!map.ContainsKey(element))
                {
                    map.Add(element, 0);
                }
                else
                {
                    map[element] += 1;
                }
            }
            foreach (double element in map.Keys)
            {
                Console.WriteLine($"{map[element]} -> {map.Keys}");
            }
        }
    }
}
