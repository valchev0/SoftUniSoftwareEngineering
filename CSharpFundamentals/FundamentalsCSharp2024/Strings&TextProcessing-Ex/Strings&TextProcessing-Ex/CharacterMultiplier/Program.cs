namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string first = strings[0];
            string second = strings[1];

            if (first.Length < second.Length)
            {
                var temp = first;
                first = second;
                second = temp;
            }

            Console.WriteLine(Sum(first, second));
        }

        static int Sum(string first, string second)
        {
            int totalSum = 0;

            for (int i = 0; i < first.Length; i++)
            {
                if (i < second.Length)
                {
                    totalSum += first[i] * second[i];
                }
                else
                {
                    totalSum += first[i];
                }
            }

            return totalSum;
        }
    }
}
