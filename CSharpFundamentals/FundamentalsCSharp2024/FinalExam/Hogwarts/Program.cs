namespace Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                string[] arr = command.Split();
                switch (arr[0])
                {
                    case "Abjuration":
                        input = input.ToUpper();
                        Console.WriteLine(input);
                        break;
                    case "Necromancy":
                        input = input.ToLower();
                        Console.WriteLine(input);
                        break;
                    case "Illusion":
                        if (int.Parse(arr[1]) >= 0 && int.Parse(arr[1]) < input.Length)
                        {
                            char[] chars = input.ToCharArray();
                            chars[int.Parse(arr[1])] = char.Parse(arr[2]);
                            input = new string(chars);
                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        break;
                    case "Divination":
                        if (input.Contains(arr[1]))
                        {
                            string temp = input.Replace(arr[1], arr[2]);
                            input = temp;
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        break;
                    case "Alteration":
                        if (input.Contains(arr[1]))
                        {
                            input = input.Replace(arr[1], string.Empty);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("The spell did not work!");
                        }
                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
            }
        }
    }
}
