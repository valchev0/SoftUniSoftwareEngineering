using System;

namespace sample 
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            int quantityNights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            switch (months) 
            {
                case "May":
                case "October":
                    studio = 50;
                    apartment= 65;
                    break;
                case "June":
                case "September":
                    studio= 75.20;
                    apartment= 68.70;
                    break;
                case "July":
                case "August":
                    studio= 76;
                    apartment= 77;
                    break;
            }
            double sumStudio = studio * quantityNights;
            double sumApartment = apartment * quantityNights;
            if (quantityNights > 14)
            {
                sumApartment *= 0.9;
            }
            if (months == "May" && quantityNights > 14 || months == "October" && quantityNights > 14)
            {
                sumStudio *= 0.7;
            }
            else if (months == "May" && quantityNights > 7 || months == "October" && quantityNights > 7)
                {
                sumStudio *= 0.95;
            }
            if (months == "June" && quantityNights > 14 || months == "September" && quantityNights > 14)
            {
                sumStudio *= 0.8;
            }
            Console.WriteLine($"Apartment: {sumApartment:f2} lv.");
            Console.WriteLine($"Studio: {sumStudio:f2} lv.");
           
        }
    }
}