namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Student> students = new();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentProps = input.Split();

                Student student = new()
                {
                    FirstName = studentProps[0],
                    LastName = studentProps[1],
                    Age = int.Parse(studentProps[2]),
                    HomeTown = studentProps[3]
                };

                students.Add(student);
            }
            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}
