using System.Numerics;

namespace MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());

            int second = int.Parse(Console.ReadLine());

            first *= second;

            Console.WriteLine(first);
        }
    }
}
