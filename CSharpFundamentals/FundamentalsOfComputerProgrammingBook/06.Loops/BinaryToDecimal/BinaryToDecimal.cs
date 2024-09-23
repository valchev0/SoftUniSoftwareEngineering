using System;
namespace BinaryToDecimal
{
    internal class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = n.ToString();
            int decimalNum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    decimalNum += 1 * ((int)Math.Pow(2, (str.Length - (i + 1))));
                }
            }
            Console.WriteLine(decimalNum);
        }
    }
}