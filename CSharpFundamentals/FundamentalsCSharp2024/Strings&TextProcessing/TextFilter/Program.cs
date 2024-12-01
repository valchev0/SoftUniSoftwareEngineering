using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

        }
    }
}
