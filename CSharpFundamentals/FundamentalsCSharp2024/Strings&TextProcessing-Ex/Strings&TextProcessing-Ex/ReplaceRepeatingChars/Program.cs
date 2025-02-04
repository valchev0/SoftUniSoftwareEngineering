namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();

            char tempChar = '\0';

            foreach (char ch in chars)
            {
                if (tempChar != ch)
                {
                    Console.Write(ch);
                }
                tempChar = ch;
            }
        }
    }
}
