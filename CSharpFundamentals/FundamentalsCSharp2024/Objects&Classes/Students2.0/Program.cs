namespace Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Student> students = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split();

                Student existingStudent = students.FirstOrDefault(s => s.FirstName == data[0] && s.LastName == data[1]);

                if (existingStudent != null)
                {
                    // Update the existing student's details
                    existingStudent.Age = int.Parse(data[2]);
                    existingStudent.HomeTown = data[3];
                }
                else
                {
                    // Add a new student if no match is found
                    Student student = new()
                    {
                        FirstName = data[0],
                        LastName = data[1],
                        Age = int.Parse(data[2]),
                        HomeTown = data[3]
                    };
                    students.Add(student);
                }
            }

            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine("{0} {1} is {2} years old.", student.FirstName, student.LastName, student.Age);
                }
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
