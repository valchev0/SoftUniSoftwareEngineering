using System;
using System.Numerics;

namespace AllPossibleCardsFromDeck
{
    internal class AllPossibleCardsFromDeck
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = int.Parse(Console.ReadLine());
            BigInteger divisor = 2;
            divisor = TopPartOfFormula(n, divisor);
            BigInteger leftDivider = 2;
            leftDivider = BottomLeftPartOfFormula(n, leftDivider);
            BigInteger rightDivider = 2;
            rightDivider = BottomRightPartOfFormula(n, rightDivider);
            BigInteger bottomSum = 0;
            bottomSum = CatalanNumbersResult(divisor, leftDivider, rightDivider);
        }

        private static BigInteger CatalanNumbersResult(BigInteger divisor, BigInteger leftDivider, BigInteger rightDivider)
        {
            BigInteger bottomSum = rightDivider * leftDivider;
            BigInteger result = divisor / bottomSum;
            Console.WriteLine(result);
            return bottomSum;
        }

        private static BigInteger BottomRightPartOfFormula(int n, BigInteger rightDivider)
        {
            int dividerRightIndicator = n;
            while (dividerRightIndicator > 0)
            {
                rightDivider *= dividerRightIndicator;
                dividerRightIndicator--;
            }

            return rightDivider;
        }

        private static BigInteger BottomLeftPartOfFormula(int n, BigInteger leftDivider)
        {
            int dividerleftIndicator = n + 1;
            while (dividerleftIndicator > 0)
            {
                leftDivider *= dividerleftIndicator;
                dividerleftIndicator--;
            }

            return leftDivider;
        }

        private static BigInteger TopPartOfFormula(int n, BigInteger divisor)
        {
            int divisorIndicator = 2 * n;
            while (divisorIndicator > 0)
            {
                divisor *= divisorIndicator;
                divisorIndicator--;
            }

            return divisor;
        }
    }
}