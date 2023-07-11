using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Създаваме си променливи за броя стъпки, които е направила и за входа от конзолата
            int steps = 0;
            string input;

            //2. Създаваме While цикъл, който да се изпълнява, докато не постигне целта си
            while (steps < 10000)
            {
                //Четем вход от конзолата
                input = Console.ReadLine();
                //Проверяваме дали входът са стъпки или е съобщението "Going home"
                if (input == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    break;
                }

                steps += int.Parse(input);
            }

            //2. Проверяваме дали е постигнала целта си
            if (steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }

            //OR
            //int totalSteps = 0;
            //    string command;
            //    int steps = 0;
            //    while (totalSteps < 10_000)
            //    {
            //        command = Console.ReadLine();
            //        if (command == "Going home")
            //        {
            //            command = Console.ReadLine();
            //            steps = int.Parse(command);
            //            totalSteps += steps;
            //            break;
            //        }
            //        steps = int.Parse(command);
            //        totalSteps += steps;
            //    }
            //    if (totalSteps >= 10_000)
            //    {
            //        Console.WriteLine("Goal reached! Good job!");
            //        Console.WriteLine($"{totalSteps - 10_000} steps over the goal!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{10_000 - totalSteps} more steps to reach goal.");
            //    }
            }
        }
    }
