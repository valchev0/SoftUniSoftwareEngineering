using System;
namespace ReadsInformationAboutCompany
{
    internal class ReadsInformationAboutCompany
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager's full name: ");
            string managerName = Console.ReadLine();
            Console.Write("His phone number: ");
            string managersPhoneNumber = Console.ReadLine();
        }
    }
}