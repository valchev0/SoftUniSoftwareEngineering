using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string input = Console.ReadLine();

            List<Name> list = new();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                if (match.Success)
                {
                    string[] parts = match.Value.Split(' ');
                    Name fullName = new Name
                    {
                        FirstName = parts[0],
                        LastName = parts[1]
                    };

                    list.Add(fullName);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
    public class Name
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
