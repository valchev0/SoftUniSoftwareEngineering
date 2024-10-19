using System;

namespace GaussTrick    
{
    internal class GaussTrick
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> results = new List<int>();
            if (ints.Count % 2 == 0)
            {
                for (int i = 0; i < ints.Count / 2; i++)
                {
                    results.Add(ints[i] + ints[(ints.Count - 1) - i]);
                }
            }
            else
            {
                for (int i = 0; i < ints.Count / 2; i++)
                {
                    results.Add(ints[i] + ints[(ints.Count - 1) - i]);
                }
                results.Add(ints[(ints.Count / 2)]);
            }
            Console.WriteLine(string.Join(" ", results));
        }
    }
}
