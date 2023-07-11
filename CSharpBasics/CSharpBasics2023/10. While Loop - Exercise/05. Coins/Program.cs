using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            //монети от: 2лв(200ст), 1лв(100ст), 50ст, 20ст, 10ст, 5ст, 2ст, 1ст

            //1. Четем от конзолата какво ресто трябва да върнем и да го превръщаме в ст.
            double changeToReturn = double.Parse(Console.ReadLine()) * 100;

            //Създаваме брояч на монетите, които връщаме
            int count = 0;

            //2. Създаваме while цикъл, който да се изпълнява, докато не върнем рестото
            while (changeToReturn > 0)
            {
                //=> при всяко изпълнение ще търсим най-голямата възможна монета
                //==> изваждаме стойноста на монетата от рестото
                if (changeToReturn >= 200)
                {
                    changeToReturn -= 200;
                }
                else if (changeToReturn >= 100)
                {
                    changeToReturn -= 100;
                }
                else if (changeToReturn >= 50)
                {
                    changeToReturn -= 50;
                }
                else if (changeToReturn >= 20)
                {
                    changeToReturn -= 20;
                }
                else if (changeToReturn >= 10)
                {
                    changeToReturn -= 10;
                }
                else if (changeToReturn >= 5)
                {
                    changeToReturn -= 5;
                }
                else if (changeToReturn >= 2)
                {
                    changeToReturn -= 2;
                }
                else if (changeToReturn >= 1)
                {
                    changeToReturn -= 1;
                }
                else
                {
                    changeToReturn = 0;
                    break;
                }
                //=> увеличаваме брояча на монети с 1
                count++;
            }


            //3. Отпечатваме броя монети, които сме върнали
            Console.WriteLine(count);

            //OR
            //decimal input = decimal.Parse(Console.ReadLine()) * 100;
            //int coins = 0;
            //while (input > 0)
            //{
            //    if (input >= 200)
            //    {
            //        coins++;
            //        input -= 200;
            //    }
            //    else if (input >= 100)
            //    {
            //        coins++;
            //        input -= 100;
            //    }
            //    else if (input >= 50)
            //    {
            //        coins++;
            //        input -= 50;
            //    }
            //    else if (input >= 20)
            //    {
            //        coins++;
            //        input -= 20;
            //    }
            //    else if (input >= 10)
            //    {
            //        coins++;
            //        input -= 10;
            //    }
            //    else if (input >= 5)
            //    {
            //        coins++;
            //        input -= 5;
            //    }
            //    else if (input >= 2)
            //    {
            //        coins++;
            //        input -= 2;
            //    }
            //    else
            //    {
            //        coins++;
            //        input = 0;
            //    }
            //}
            //Console.WriteLine(coins);
        }
    }
}
