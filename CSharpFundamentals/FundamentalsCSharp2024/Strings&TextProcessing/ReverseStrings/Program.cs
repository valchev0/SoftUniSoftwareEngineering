namespace ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;

            while ((word = Console.ReadLine()) != "end")
            {
                char[] chrArr = word.Reverse().ToArray();

                Console.WriteLine($"{word} = {string.Join("", chrArr)}");
            }
        }
    }
}
