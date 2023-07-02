using System;


namespace FruitShop
{
    internal class FruitShop
    {
        static void Main(string[] args)
        {


            //94/100

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            //if (fruit == "tomato")
            //{
            //    Console.WriteLine("error");
            //}
            //if (fruit == "beer")
            //{
            //    Console.WriteLine("error");
            //}
            if ((fruit != "banana" && fruit != "apple" && fruit != "orange" && fruit != "grapefruit" && fruit != "kiwi" && fruit != "pineapple" && fruit != "grapes"))
            {
                Console.WriteLine("error");
            }
            if ((day != "Monday" && day != "Tuesday" && day != "Wednesday" && day != "Thursday" && day != "Friday" && day != "Saturday" && day != "Sunday"))
            {
                Console.WriteLine("");
            }

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine($"{quantity * 2.5:f2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{(quantity * 1.2):f2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{quantity * 0.85:f2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{quantity * 1.45:f2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{quantity * 2.7:f2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{quantity * 5.5:f2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{quantity * 3.85:f2}");
                            break;

                    }
                    break;

                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine($"{quantity * 2.7:f2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{quantity * 1.25:f2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{quantity * 0.9:f2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{quantity * 1.6:f2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{quantity * 3:f2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{quantity * 5.6:f2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{quantity * 4.2:f2}");
                            break;

                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
                    //if (fruit == "tomato")
                    //{
                    //    Console.WriteLine("error");
                    //}

            }
        }
    }
}