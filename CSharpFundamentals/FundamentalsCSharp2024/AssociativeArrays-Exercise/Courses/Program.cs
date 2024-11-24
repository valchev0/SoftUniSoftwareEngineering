namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Cource> courses = new();
            string input;
            
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(" : ");

                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new()
                    {
                        CourseName = courseName,
                        StudentNames = new List<string> { studentName }
                    };
                }
                else
                {
                    courses[courseName].StudentNames.Add(studentName);
                }
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.StudentNames.Count}");
                foreach (var student in course.Value.StudentNames)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
    public class Cource
    {
        public string CourseName { get; set; }

        public List<string> StudentNames { get; set; }
    }
}
