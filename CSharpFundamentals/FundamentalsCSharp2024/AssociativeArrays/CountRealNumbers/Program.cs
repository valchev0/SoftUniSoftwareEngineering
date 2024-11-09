namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> map = new SortedDictionary<double, int>();

            foreach (var element in array)
            {
                if (map.ContainsKey(element))
                {
                    map[element]++;
                }
                else
                {
                    map.Add(element, 1);
                }
            }
            foreach (var element in map)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
