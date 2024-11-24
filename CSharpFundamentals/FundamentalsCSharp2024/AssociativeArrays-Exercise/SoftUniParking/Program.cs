namespace SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Parking> registers = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string userName = tokens[1];

                switch (tokens[0])
                {
                    case "register":
                        string licensePlateNumber = tokens[2];
                        if (!registers.ContainsKey(tokens[1]))
                        {
                            registers[userName] = new Parking()
                            {
                                Name = userName,
                                PlateNumber = licensePlateNumber
                            };
                            Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                            break;
                        }
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        continue;
                    case "unregister":
                        if (!registers.ContainsKey(tokens[1]))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                            continue;
                        }
                        registers.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                        break;
                }
            }
            foreach (var register in registers)
            {
                Console.WriteLine($"{register.Key} => {register.Value.PlateNumber}");
            }
        }
    }
    public class Parking
    {
        public string Name { get; set; }

        public string PlateNumber { get; set; }
    }
}
