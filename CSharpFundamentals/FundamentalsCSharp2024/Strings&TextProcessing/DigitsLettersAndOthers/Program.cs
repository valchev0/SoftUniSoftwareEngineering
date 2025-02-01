using System.Text;
using System.Linq;

namespace DigitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalString = Console.ReadLine();

            string digits = new string(originalString.Where(char.IsDigit).ToArray());

            Console.WriteLine(digits);

            string letters = new string(originalString.Where(char.IsLetter).ToArray());

            Console.WriteLine(letters);

            string symbols = new string(originalString.Where(ch => !char.IsLetterOrDigit(ch)).ToArray());

            Console.WriteLine(symbols);
        }
    }
}
