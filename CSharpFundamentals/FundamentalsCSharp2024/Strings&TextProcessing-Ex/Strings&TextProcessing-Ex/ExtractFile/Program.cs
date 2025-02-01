using System.Text;

namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            string extension = path.Substring(path.LastIndexOf('.') + 1);

            StringBuilder fileName = new StringBuilder(path.Substring(path.LastIndexOf('\\') + 1).Replace(extension, ""));

            Console.WriteLine($"File name: {fileName.Replace(".", "")}");

            Console.WriteLine($"File extension: {extension}");
        }
    }
}
