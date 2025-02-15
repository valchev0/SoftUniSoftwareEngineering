using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<Day>[0-9][0-9])(.|-|\/)(?<Month>[A-Z][a-z]{2})\1(?<Year>\d{4})";

            string input = Console.ReadLine();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                if (match.Success)
                {
                    Console.WriteLine($"Day: {match.Groups["Day"].Value}, " +
                        $"Month: {match.Groups["Month"].ToString()}, " +
                        $"Year: {match.Groups["Year"].Value}");
                }
            }
        }
    }
}
