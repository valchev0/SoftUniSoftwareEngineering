namespace TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool areFul = false;
            int counter = 0;
            int queue = 0;

            for (int i = 1; i <= people; i++)
            {
                if (counter > wagons.Length - 1)
                {
                    queue = i;
                    areFul = true;
                    break;
                }
                wagons[counter]++;
                if (wagons[counter] == 4)
                {
                    counter++;
                }
            }
            if (areFul)
            {
                Console.WriteLine(($"There isn't enough space! {queue - 1} people in a queue!"));
            }
            else
            {
                Console.WriteLine($"The lift has empty spots!");
            }
            Console.WriteLine(string.Join(" ", wagons));
            
        }
    }
}
