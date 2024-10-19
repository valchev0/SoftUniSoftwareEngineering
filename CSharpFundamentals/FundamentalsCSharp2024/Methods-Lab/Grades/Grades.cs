using System;

namespace Grades
{
    internal class Grades
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            string result = string.Empty;
            result = GradesResult(grade);
            Console.WriteLine(result);
        }

        private static string GradesResult(double grade)
        {
            string result;
            if (grade >= 2 && grade < 3)
            {
                result = "Fail";
            }
            else if (grade >= 3 && grade < 3.5)
            {
                result = "Poor";
            }
            else if (grade >= 3.5 && grade < 4.5)
            {
                result = "Good";
            }
            else if (grade >= 4.5 && grade < 5.5)
            {
                result = "Very good";
            }
            else
            {
                result = "Excellent";
            }

            return result;
        }
    }
}