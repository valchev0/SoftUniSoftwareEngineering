using System;

namespace Grades
{
    internal class Grades
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            double gradesTotal = 0;
            int failGradeCounter = 0;
            int lowGradeCounter = 0;
            int averageGradeCounter = 0;
            int highGradeCounter = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                gradesTotal += currentGrade;
                if (currentGrade >= 2 && currentGrade <= 2.99)
                {
                    failGradeCounter++;
                }
                else if (currentGrade >= 3 && currentGrade <= 3.99)
                {
                    lowGradeCounter++;
                }
                else if (currentGrade >= 4 && currentGrade <= 4.99)
                {
                    averageGradeCounter++;
                }
                else if (currentGrade >= 5 && currentGrade <= 6)
                {
                    highGradeCounter++;
                }
            }
            double averageGradeTotal = gradesTotal / studentsCount;
            double highGradePercenteges = ((double)highGradeCounter / studentsCount) * 100;
            double averageGradePercenteges = ((double)averageGradeCounter / studentsCount) * 100;
            double lowGradePercenteges = ((double)lowGradeCounter / studentsCount) * 100;
            double failGradePercenteges = ((double)failGradeCounter / studentsCount) * 100;
            Console.WriteLine("Top students: {0:f2}%", highGradePercenteges);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", averageGradePercenteges);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", lowGradePercenteges);
            Console.WriteLine("Fail: {0:f2}%", failGradePercenteges);
            Console.WriteLine($"Average: {averageGradeTotal:f2}");
        }
    }
}