using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("I am Goshow");

            sb.AppendLine(", I am a programmer");

            Console.WriteLine(sb);
        }
    }
}
