using System.Xml.Linq;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input = string.Empty;

            decimal sum = 0;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] array = input.Split();

                string name = array[0];
                decimal price = decimal.Parse(array[1]);
                int quantity = int.Parse(array[2]);

                if (!products.ContainsKey(name))
                {
                    products[name] = new Product()
                    {
                        Name = name,
                        Price = price,
                        Quantity = quantity
                    };
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quantity;
                }
                products[name].Sum = products[name].Price * products[name].Quantity;
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value.Sum):F2}");
            }
        }
    }
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal Sum { get; set; }
    }
}
