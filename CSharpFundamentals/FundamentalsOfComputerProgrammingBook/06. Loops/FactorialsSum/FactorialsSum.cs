using System;
using System.Numerics;

namespace FactorialsSum
{
    internal class FactorialsSum
    {
        static void Main(string[] args)
        {
            //N!*K!/(N-K)! 
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger numN = 1;
            BigInteger numK = 1;
            bool isDone = false;
            BigInteger result = 0;
            int nMinusK = Math.Abs(n - k);
            BigInteger numNK = 1;

            while (!isDone)
            {
                while (n > 0)
                {
                    numN *= n;
                    n--;
                }
                Console.WriteLine("!N is: {0}", numN);
                while (k > 0)
                {
                    numK *= k;
                    k--;
                }
                Console.WriteLine("!K is: {0}", numK);
                while (nMinusK > 0)
                {
                    numNK *= nMinusK;
                    nMinusK--;
                }
                Console.WriteLine("(N - K)! is: {0}", numNK);
                result = (numN * numK) / numNK;
                Console.WriteLine("N!*K!/(N-K)!: {0}", result);
                isDone = true;
            }
        }
    }
}