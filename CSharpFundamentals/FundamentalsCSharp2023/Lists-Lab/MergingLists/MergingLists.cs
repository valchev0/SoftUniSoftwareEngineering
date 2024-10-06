namespace MergingLists
{
    internal class MergingLists
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> results = new List<int>();

            int n = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < n; i++)
            {
                results.Add(firstList[i]);
                results.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                results.AddRange(firstList.GetRange(n, firstList.Count - n));
            }
            else if (secondList.Count > firstList.Count)
            {
                results.AddRange(secondList.GetRange(n, secondList.Count - n));
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
