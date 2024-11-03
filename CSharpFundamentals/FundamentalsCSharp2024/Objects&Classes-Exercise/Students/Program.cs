namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(':',' ');
                Student student = new()
                {
                    FirstName = tokens[0],
                    LastName = tokens[1],
                    Grade = double.Parse(tokens[2])
                };
                students.Add(student);
            }
            List<Student> orderedStudents = students.OrderByDescending(student => student.Grade).ToList();
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
