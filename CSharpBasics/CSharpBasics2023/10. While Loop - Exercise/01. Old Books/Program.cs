using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата заглавието на любимата книга 
            string favoriteBook = Console.ReadLine();

            int count = 0;
            string input = Console.ReadLine();

            //2. Създаваме while цикъл, който да се изпълнява,
            //   докато не проверим всички книги
            while (input != "No More Books")
            {
                //=> проверяваме дали това е любимата книга
                if (input == favoriteBook)
                {
                    //==> ако е: спираме цикъла
                    break;
                }
                //==> ако не е: увеличаваме брояча на книгите, които сме проверили с 1
                count++;
                //=> Четем от конзолата заглавие на следваща книга 
                input = Console.ReadLine();
            }

            //3. Извеждаме изхода на конзолата
            if (input == favoriteBook)
            {
                // => ако сме намерили книгата-
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                // => ако не сме намерили любимата книга

                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
            //OR
            //string favoriteBook = Console.ReadLine();
            //string input;
            //int bookCounter = 0;
            //while ((input = Console.ReadLine()) != "No More Books" && input != favoriteBook)
            //{
            //    bookCounter++;
            //}
            //if (input == favoriteBook)
            //{
            //    Console.WriteLine($"You checked {bookCounter} books and found it.");
            //}
            //else
            //{
            //    Console.WriteLine("The book you search is not here!");
            //    Console.WriteLine($"You checked {bookCounter} books.");
            //}
        }
    }
}