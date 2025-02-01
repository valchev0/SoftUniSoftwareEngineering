namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            List <string> validNames = new();

            foreach (string username in usernames)
            {
                bool isValidName = username.All(character => char.IsLetterOrDigit(character) ||
                                                             character == '_' ||
                                                             character == '-');
                if (username.Length >= 3
                    && username.Length <= 16
                    && isValidName)
                {
                    if (!validNames.Contains(username))
                    {
                        validNames.Add(username);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, validNames));
        }
    }
}
