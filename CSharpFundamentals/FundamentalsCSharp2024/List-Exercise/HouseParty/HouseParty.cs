using System.Net.WebSockets;

namespace HouseParty
{
    internal class HouseParty
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();



            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (arr.Length == 3)
                {
                    if (!list.Contains(arr[0]))
                    {
                        list.Add(arr[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0} is already in the list!", arr[0]);
                    }
                }
                else
                {
                    if(list.Contains(arr[0]))
                    {
                        list.Remove(arr[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not in the list!", arr[0]);
                    }
                }
            }
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
