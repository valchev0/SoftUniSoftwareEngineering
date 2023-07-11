using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInJury = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();

            double averageScoreForAllPresentation = 0;
            int counter = 0;

            while (nameOfPresentation != "Finish")
            {
                double averageScore = 0;

                for (int i = 0; i < peopleInJury; i++)
                {
                    double currentScore = double.Parse(Console.ReadLine());

                    averageScore += currentScore;
                    averageScoreForAllPresentation += currentScore;
                    counter++;
                }

                double averageScorePerPresentation = averageScore / peopleInJury;

                Console.WriteLine($"{nameOfPresentation} - {averageScorePerPresentation:F2}.");

                nameOfPresentation = Console.ReadLine();
            }

            double assesment = averageScoreForAllPresentation / counter;

            Console.WriteLine($"Student's final assessment is {assesment:F2}.");


            //OR
            //int jury = int.Parse(Console.ReadLine());
            //string task;
            //int tasksCounter = 0;
            //double totalGrades = 0;
            //int gradeCounter = 0;
            //while ((task = Console.ReadLine()) != "Finish")
            //{
            //    double taskGrade = 0;
            //    tasksCounter = 0;
            //    while (tasksCounter < jury)
            //    {
            //        double currentGrade = double.Parse(Console.ReadLine());
            //        taskGrade += currentGrade;
            //        tasksCounter++;
            //    }
            //    gradeCounter += tasksCounter;
            //    totalGrades += taskGrade;
            //    Console.WriteLine($"{task} - {(taskGrade / jury):f2}.");
            //}
            //Console.WriteLine($"Student's final assessment is {(totalGrades / gradeCounter):f2}.");
        }
    }
}