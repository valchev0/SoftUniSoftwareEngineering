using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата брой на незадоволителните оценки, които може да получи
            int filedTimes = int.Parse(Console.ReadLine());

            //2. Създаваме променливи за: 
            //=> сумата на всички оценки
            int evoluationSum = 0;
            //=> брояч на всички оценки
            int evoluationCount = 0;
            //=> брояч на незадоволителните оценки
            int filedCount = 0;
            //=> име на последна задача 
            string lastExercise = string.Empty;

            string input = Console.ReadLine();
            int evoluation;
            //3. Създаваме while, който да се изпълнява, докато не получи съобщение "Enough"
            while (input != "Enough")
            {
                // => ако input-ът е различен от "Enough" => той е име на ПОСЛЕДНАТА задача до момента
                lastExercise = input;
                // => четем оценка за конкретната задача
                evoluation = int.Parse(Console.ReadLine());

                // => добавяме оценката към сумата на всички оценки до момента
                evoluationSum += evoluation;
                // => увеличаваме брояча на всички оценки с 1
                evoluationCount++;

                // => проверяваме тази оценка нeзадоволителна ли е? 
                if (evoluation <= 4)
                {
                    //увеличаваме брояча на незадоволителните оценки с 1
                    filedCount++;

                    //=> проверяваме дали е достигнал броя на незадоволителните оценки, за да прекъсне
                    if (filedCount == filedTimes)
                    {
                        Console.WriteLine($"You need a break, {filedCount} poor grades.");
                        //==> спираме изпълнението на цикъла
                        break;
                    }
                }

                //=> четем нов вход от конзолата
                input = Console.ReadLine();
            }

            //4. Проверяваме дали последният input == "Enough"
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {(double)evoluationSum / evoluationCount:f2}");
                Console.WriteLine($"Number of problems: {evoluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
            //OR
            //int numberBadGrades = int.Parse(Console.ReadLine());
            //string task;
            //int currentGrade;
            //int taskCounter = 0;
            //decimal gradesSum = 0;
            //string lastTask = string.Empty;
            //int badGradesCounter = 0;

            //while ((task = Console.ReadLine()) != "Enough")
            //{
            //    taskCounter++;
            //    currentGrade = int.Parse(Console.ReadLine());
            //    if (currentGrade <= 4)
            //    {
            //        badGradesCounter++;
            //        if (numberBadGrades == badGradesCounter)
            //        {
            //            Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
            //            break;
            //        }
            //    }
            //    gradesSum += currentGrade;
            //    lastTask = task;
            //}
            //if (task == "Enough")
            //{
            //    Console.WriteLine($"Average score: {gradesSum / taskCounter:f2}");
            //    Console.WriteLine($"Number of problems: {taskCounter}");
            //    Console.WriteLine($"Last problem: {lastTask}");
            //}
        }
    }
}
