using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата пари, необходими за екскурзията и спестени до момента
            double needeMoney = double.Parse(Console.ReadLine());
            double avaliableMoney = double.Parse(Console.ReadLine());

            // Създаваме променливи за:
            string input; //spend/save
            double money;
            int daysCount = 0;
            int spendCount = 0;

            //2. създаваме цикъл, който да се изпълнява, докато не събере достатъчно пари 
            while (avaliableMoney < needeMoney)
            {
                //четем действие от конзолата =>  spend/save
                input = Console.ReadLine();
                //четем сума, която спестява или харчи
                money = double.Parse(Console.ReadLine());

                //увеличаваме брояча на общо изминалите дни с 1
                daysCount++;

                //проверяваме дали спестява или харчи
                if (input == "save")//ако спестява:
                {
                    //==> добавяме парите към спестяванията (+)
                    avaliableMoney += money;
                    //==> нулираме брояча на ПОРЕДНИТЕ дни, в които харчи
                    spendCount = 0;
                }
                else // ако харчи:
                {
                    //==> увеличаваме брояча на ПОРЕДНИТЕ дни, в които харчи
                    spendCount++;
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }

                    //==> изваждаме парите от спестяванията (-)
                    avaliableMoney -= money;
                    //==> проверяваме дали парите не са станали <0 => =0
                    if (avaliableMoney < 0)
                    {
                        avaliableMoney = 0;
                    }
                }
            }

            //3. Проверяваме дали е успяла да спести достатъчно пари
            if (avaliableMoney >= needeMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }

            //OR
            //decimal holidayCost = decimal.Parse(Console.ReadLine());
            //decimal moneyOnHand = decimal.Parse(Console.ReadLine());
            //string command;
            //decimal amount;
            //int spendCounter = 0;
            //int daysCounter = 0;
            //while (moneyOnHand < holidayCost)
            //{
            //    daysCounter++;
            //    command = Console.ReadLine();
            //    amount = decimal.Parse(Console.ReadLine());
            //    if (command == "save")
            //    {
            //        moneyOnHand += amount;
            //        spendCounter = 0;
            //    }
            //    else
            //    {
            //        moneyOnHand -= amount; spendCounter++;

            //        if (moneyOnHand < 0)
            //        {
            //            moneyOnHand = 0;
            //        }
            //        if (spendCounter >= 5)
            //        {
            //            Console.WriteLine("You can't save the money.");
            //            Console.WriteLine(daysCounter);
            //            break;
            //        }
            //    }
            //    if (moneyOnHand >= holidayCost)
            //    {
            //        Console.WriteLine($"You saved the money for {daysCounter} days.");
            //        break;
            //    }
            //}
        }
    }
}
