using System.Text;

namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();

            foreach (var word in array)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
