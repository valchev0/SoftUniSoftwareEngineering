namespace RemoveNegativesAndReverse
{
    internal class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            AbsorbingMethod(list, result);
            PrintingMethod(result);
        }
        private static void AbsorbingMethod(List<int> list, List<int> result)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    result.Add(list[i]);
                }
            }
        }
        private static void PrintingMethod(List<int> result)
        {
            if (result.Count > 0)
            {
                result.Reverse();
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
