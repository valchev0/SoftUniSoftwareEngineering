using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ExtractMiddleElements
{
    internal class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string message = null;
            if (arr.Length == 1)
            {
                message = string.Format("{{ {0} }}", arr[0]);
            }
            else if (arr.Length % 2 == 0)
            {
                int first = (arr.Length / 2) - 1;
                int second = (arr.Length / 2);
                message = string.Format("{{ {0}, {1} }}", arr[first], arr[second]);
            }
            else
            {
                int first = (arr.Length / 2) - 1;
                int second = (arr.Length / 2);
                int third = (arr.Length / 2) + 1;

                message = string.Format("{{ {0}, {1}, {2} }}", arr[first], arr[second], arr[third]);
            }

            Console.WriteLine(message);
        }
    }
}
