using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата: темп. и време от денонощието
            int degrees = int.Parse(Console.ReadLine()); //[10-42]
            string time = Console.ReadLine(); //"Morning", "Afternoon", "Evening"

            string outfit = string.Empty;
            string shoes = string.Empty;

            //2. Проверяваме кое време от денонощието е
            if (time == "Morning")
            {
                //    => Допълнителна проверка за темп.
                if (degrees <= 18)
                {
                    //[10-18]
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees <= 24)
                {
                    //[19-24]
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else //[25-42]
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (time == "Afternoon")
            {
                //    => Допълнителна проверка за темп.
                if (degrees <= 18)
                {
                    //[10-18]
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees <= 24)
                {
                    //[19-24]
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    //[25-42]
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else // => "Evening"
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }


            //3. Отпечатваме резултата на конзолата
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}   