/*
 
 */
namespace ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;
            int temp = 0;
            int shooter = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int target = int.Parse(command);

                if (target > -1 && target < array.Length)
                {
                    if (array[target] != -1)
                    {
                        temp = array[target];
                        array[target] = -1;
                        shooter++;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] != -1)
                            {
                                 if (array[i] > temp)
                                 {
                                     array[i] -= temp;
                                 }
                                 else
                                 {
                                     array[i] += temp;
                                 }
                            }
                        }
                    }
                }
            }
            Console.Write($"Shot targets: {shooter} -> ");
            Console.Write(string.Join(" ", array));
        }
    }
}
