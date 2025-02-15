using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}(?!\d)";

            string input = Console.ReadLine();

            var phoneMatches = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", phoneMatches.Select(x => x.Groups[0])));
        }
    }
}
