using System.Text;

namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int strength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '>' && strength <= 0)
                {
                    sb.Append(input[i]);
                }
                else if (Char.IsLetterOrDigit(input[i]) && strength <= 0)
                {
                    sb.Append(input[i]);
                }
                else if (input[i] == '>')
                {
                    sb.Append(input[i]);
                    strength += input[i + 1] - '0';
                }
                else if (strength > 0)
                {
                    strength--;
                }
                else
                {
                    sb.Append(input[i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
