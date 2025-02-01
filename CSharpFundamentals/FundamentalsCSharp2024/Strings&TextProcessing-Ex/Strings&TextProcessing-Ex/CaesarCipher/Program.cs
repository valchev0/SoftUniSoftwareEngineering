using System.Text;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = Console.ReadLine().ToCharArray();

            StringBuilder sb = new StringBuilder();

            foreach (char ch in charArray)
            {
                char shift = (char)(ch + 3);
                sb.Append(shift);
            }
            Console.WriteLine(string.Join("", sb));
        }
    }
}
