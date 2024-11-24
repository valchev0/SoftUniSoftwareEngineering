namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new();
            string input;
            
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" -> ");
                string name = tokens[0];
                string id = tokens[1];

                if (!companies.ContainsKey(name))
                {
                    companies[name] = new Company()
                    {
                        CompanyName = name,
                        CompanyIds = new List<string>() { id }
                    };
                }
                else if (!companies[name].CompanyIds.Contains(id))
                {
                    companies[name].CompanyIds.Add(id);
                }
            }
            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var id in company.Value.CompanyIds)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
    public class Company
    {
        public string CompanyName { get; set; }

        public List<string> CompanyIds { get; set; }
    }
}
