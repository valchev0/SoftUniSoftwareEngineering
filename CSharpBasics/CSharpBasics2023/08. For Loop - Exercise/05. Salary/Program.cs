using System;


namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            for (int i = 1; i <= n ; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }
                if (salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine($"{salary:f0}");
            //OR
            //int tabs = int.Parse(Console.ReadLine());
            //double salary = double.Parse(Console.ReadLine());
            //for (int i = 1; i <= tabs; i++)
            //{
            //    string websait = Console.ReadLine();
            //    switch (websait)
            //    {
            //        case "Facebook":
            //            salary -= 150;
            //            break;
            //        case "Instagram":
            //            salary -= 100;
            //            break;
            //        case "Reddit":
            //            salary -= 50;
            //            break;
            //    }
            //    if (salary <= 0)
            //    {
            //        Console.WriteLine("You have lost your salary.");
            //        break;
            //    }
            //}
            //if (salary > 0)
            //{
            //    Console.WriteLine(salary);
            //}
        }
    }
}