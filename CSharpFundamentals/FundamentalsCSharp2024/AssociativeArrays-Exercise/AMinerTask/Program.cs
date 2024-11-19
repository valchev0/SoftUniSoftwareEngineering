namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Resources> resources = new();

            string input;

            while ((input = Console.ReadLine()) != "stop")
            {
                string nameResource = input;
                string temp = Console.ReadLine();
                uint amount;


                if (!uint.TryParse(temp, out amount))
                {
                    continue;
                }

                if (!resources.ContainsKey(nameResource))
                {
                    resources[nameResource] = new Resources()
                    {
                        resource = nameResource,
                        quantity = amount
                    };
                }
                else
                {
                    resources[nameResource].quantity += amount; 
                }
            }
            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value.quantity}"); 
            }
        }
    }
    public class Resources
    {
        public string resource { get; set; }

        public uint quantity { get; set; }
    }
}
