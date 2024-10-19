using System;
using System.Numerics;

namespace Snowballs
{
    internal class Snowballs
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            int snowballQuality = 0;
            BigInteger bestSnowball = int.MinValue;
            BigInteger snowballValue = 0;
            string snowballFormula = string.Empty;

            for (int i = 0; i < snowballs; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                BigInteger currentSnowballValue = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(currentSnowballValue, snowballQuality);
                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    snowballFormula = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }
            Console.WriteLine(snowballFormula);
        }
    }
}