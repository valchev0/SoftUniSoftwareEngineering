namespace ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string customerType = Console.ReadLine();

            decimal discount = 0.2M;

            string input = string.Empty;

            decimal priceWithoutTaxes = 0;

            while ((input = Console.ReadLine()) != "regular" && input != "special")
            {
                decimal amount = decimal.Parse(input);

                if (amount > 0)
                {
                    priceWithoutTaxes += amount;
                }
                else if (amount == 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
            }

            decimal taxes = discount * priceWithoutTaxes;

            decimal totalPrice = priceWithoutTaxes + taxes;

            switch (input)
            {
                case "special":
                    totalPrice -= totalPrice * 0.1m;
                    break;
            }

            if (totalPrice > 0)
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!\n" +
                    $"Price without taxes: {priceWithoutTaxes:F2}$\n" +
                    $"Taxes: {taxes:F2}$\n" +
                    $"-----------\n" +
                    $"Total price: {totalPrice:F2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
