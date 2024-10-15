using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Четене на входните данни
            string input = Console.ReadLine();

            // Разделяне на масивите по '|'
            string[] arrays = input.Split('|', StringSplitOptions.RemoveEmptyEntries);

            // Създаване на нов списък за резултата
            List<int> result = new List<int>();

            // Обработка на масивите отдясно наляво
            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                // Разделяне на стойностите в текущия масив и добавяне към резултата
                result.AddRange(arrays[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse));
            }

            // Извеждане на резултата
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
