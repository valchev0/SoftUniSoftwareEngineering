using System.Text;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string remover = Console.ReadLine();

            string chars = Console.ReadLine();

            while (chars.Contains(remover))
            {
                chars = chars.Replace(remover, "");
            }
            string newString = chars;
            Console.WriteLine(newString);
        }
    }
}
